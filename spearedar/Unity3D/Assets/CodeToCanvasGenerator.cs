﻿using Microsoft.MixedReality.Toolkit.Utilities;
using RosSharp.RosBridgeClient;
using System;
using System.Collections;
using System.Collections.Generic;
using RosSharp;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CodeToCanvasGenerator : MonoBehaviour
{
    public Canvas canvas;
    public Transform rootCanvasUI;
    public Program currentProgram;
    public Text programCodeUnformatted;
    public Text programCodeFormatted;
    public ICommandUIRepresentation commandUIRepresentation;
    GameObject rootCommandObject;
    public CoordinateTargetSelector coordinateTargetSelector;

    public GridObjectCollection baseObjectCollection;

    public RosSharp.RosBridgeClient.RosConnector RosConnector;
    public ExecuteGeneratedProgram myExecutor;


    // Start is called before the first frame update
    void Start()
    {
        RobotProgramStructure robotProgramStructure = new RobotProgramStructure();
        this.currentProgram = robotProgramStructure.sampleProgram;
        drawCurrentCode();

    }  
    public void redraw()
    {
        foreach(Transform child in rootCanvasUI)
        {
            if (child.name.StartsWith("Command"))
            {
                child.gameObject.SetActive(false);
                Destroy(child.gameObject);
            }
            
        }
        drawCurrentCode();
    }
    public void convertCodeToProgram()
    {
        convertCodeToProgram(this.programCodeUnformatted.text);
        redraw();
    }
    public void convertCodeToProgram(string code)
    {
        Program program = new Program();
        List<Statement> statements = new List<Statement>();
        foreach(string line in code.Split('\n'))
        {
            if (line.Contains("Move"))
            {
                string strippedLine = line.Replace("Move", "");
                strippedLine = strippedLine.Trim(new char[] { '(', ')', ';' });
                strippedLine = strippedLine.Trim();
                string[] commandValues = strippedLine.Split(' ');
                statements.Add(statementFromString(commandValues));
            }
            else
            {
                if (line.Contains("ToggleSuction"))
                {
                    bool isSuctionEnabled = false;
                    string strippedLine = line.Replace("ToggleSuction", "");
                    strippedLine = strippedLine.Trim(new char[] { '(', ')', ';' });
                    strippedLine = strippedLine.Trim();
                    bool.TryParse(strippedLine, out isSuctionEnabled);
                    ToggleSuction toggle = new ToggleSuction();
                    toggle.isSuctionEnabled = isSuctionEnabled;
                    statements.Add(toggle);
                }
            }
        }
        program.statements = statements;
        this.currentProgram = program;
    }
    private MoveStatement statementFromString(string[] commandValues)
    {
        if (commandValues.Length == 6) // movementType, x,y,z,r,isQueued
        {
            return statementFromString(commandValues[0], commandValues[1], commandValues[2], commandValues[3], commandValues[4]);
        }
        else
        {
            if(commandValues.Length == 3) // x,y,z
            {
                return statementFromString("1", commandValues[0], commandValues[1], commandValues[2], "0");
            }
        }
        return new MoveToJ();
    }
    private MoveStatement statementFromString(string movementType, string x, string y, string z, string r)
    {
        try
        {
            return statementFromParsedString(int.Parse(movementType), float.Parse(x), float.Parse(y), float.Parse(z), float.Parse(r));
        }
        catch (Exception e){
            return new MoveToJ();

        }
    }
    private MoveStatement statementFromParsedString(int movementType, float x, float y, float z, float r)
    {
        Vector4 target = new Vector4(x, y, z, r);
        MoveStatement moveStatement = new MoveToJ(); // default
        switch (movementType)
        {
            case 0:
                moveStatement = new MoveToL();
                break;
            case 1:
                moveStatement = new MoveToJ();
                break;
            case 2:
                moveStatement = new JumpTo();
                break;
            case 3:
                moveStatement = new MoveArc();
                break;
            default:
                moveStatement = new MoveToJ();
                break;
        }
        moveStatement.target = target;
        return moveStatement;
    }
    private void drawCurrentCode()
    {

        GameObject dropdownObject;// = new GameObject();
        float distanceCounter = 0.5f;
        
        

        foreach (Statement statement in currentProgram.statements)
        {
            dropdownObject = commandUIRepresentation.constructCommandUIComponent("Command" + (int)distanceCounter, statement);
            dropdownObject.transform.SetParent(rootCanvasUI, false);
           
            
            if (baseObjectCollection != null)
            {
                
            }
            else{
                dropdownObject.transform.localPosition += new Vector3(0, -distanceCounter * commandUIRepresentation.getCommandObjectBoundaries().height, 0);
                
            }
            distanceCounter += 1f;
        }
        foreach (MoveCodeCommand moveCodeCommand in rootCanvasUI.GetComponentsInChildren<MoveCodeCommand>())
        {
            moveCodeCommand.ctcGenerator = this;
        }
        foreach(DeleteCodeCommand deleteCodeCommand in rootCanvasUI.GetComponentsInChildren<DeleteCodeCommand>())
        {
            deleteCodeCommand.ctcGenerator = this;
        }
        foreach (AddCodeCommand addCodeCommand in rootCanvasUI.GetComponentsInChildren<AddCodeCommand>())
        {
            addCodeCommand.ctcGenerator = this;
        }
        foreach (SetBreakpointCommand setBreakpointCommand in rootCanvasUI.GetComponentsInChildren<SetBreakpointCommand>())
        {
            setBreakpointCommand.executeGeneratedProgram = myExecutor;
        }
        foreach (AddSuctionToggleCommand addSuctionToggleCommand in rootCanvasUI.GetComponentsInChildren<AddSuctionToggleCommand>())
        {
            addSuctionToggleCommand.ctcGenerator = this;
        }
        if (baseObjectCollection != null)
        {
            baseObjectCollection.UpdateCollection();
        }

    }
    public Program generateProgramFromTransform()
    {
        return generateProgramFromTransform(this.rootCanvasUI);
    }
    private Program generateProgramFromTransform(Transform codeRootTransform)
    {
        Program program = new Program();
        List<Transform> transforms = new List<Transform>();
        codeRootTransform.GetComponentsInChildren<Transform>(transforms);
        List<Statement> statements = new List<Statement>();
        Statement statement;
        foreach (Transform commandTransform in transforms)
        {
            if (commandTransform.name.StartsWith("Command"))
            {
                
                
                    statement =  commandUIRepresentation.generateStatementFromUI(commandTransform.gameObject);
                    statements.Add(statement);
                
            }
        }
        program.statements = statements;
        return program;
    }
    private String generateProgramStringFromProgram()
    {
        return generateProgramStringFromProgram(this.currentProgram);
    }
    private String generateProgramStringFromProgram(Program program)
    {
        String programString = "";
        foreach (Statement statement in program.statements)
        {
            if (statement.GetType().IsSubclassOf(typeof(MoveStatement)))
            {
                RosSharp.RosBridgeClient.MessageTypes.Dobot.SetPTPCmdRequest request;
                MoveStatement moveStatement = (MoveStatement)statement;
                byte ptpMode_byte;
                byte.TryParse("" + moveStatement.movementValueForCanvas, out ptpMode_byte);
                float x = moveStatement.target.x;
                float y = moveStatement.target.y;
                float z = moveStatement.target.z;
                float r = 0f;
                request = new RosSharp.RosBridgeClient.MessageTypes.Dobot.SetPTPCmdRequest(ptpMode_byte, x, y, z, r, true);
                programString += $"Move({request.x} {request.y} {request.z});\n";
            }
            else
            {
                if(statement is ToggleSuction)
                {
                    ToggleSuction toggleSuction = (ToggleSuction)statement;
                    programString += $"ToggleSuction({toggleSuction.isSuctionEnabled});\n";
                }
            }
        }
        return programString;
    }

    public void fillProgramCodeUI()
    {

        this.currentProgram = this.generateProgramFromTransform();

        //############DEBUGGING##########################
        myExecutor.connector = this.RosConnector;
        myExecutor.currentProgram = this.currentProgram;
        myExecutor.StartProgram();
        //############DEBUGGING########################
        
        this.programCodeUnformatted.text = generateProgramStringFromProgram();
    }
    

}

