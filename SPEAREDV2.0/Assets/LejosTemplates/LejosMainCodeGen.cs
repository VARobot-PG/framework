﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion: 15.0.0.0
//  
//     Änderungen an dieser Datei können fehlerhaftes Verhalten verursachen und gehen verloren, wenn
//     der Code neu generiert wird.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Assets.LejosTemplates
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\varobotprojectgroup\SPEAREDV2.0\Assets\LejosTemplates\LejosMainCodeGen.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class LejosMainCodeGen : LejosMainCodeGenBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("package ");
            
            #line 6 "D:\varobotprojectgroup\SPEAREDV2.0\Assets\LejosTemplates\LejosMainCodeGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PackageName()));
            
            #line default
            #line hidden
            this.Write(@";
import java.io.IOException;

import lejos.nxt.Button;
import lejos.robotics.RegulatedMotor;
import lejos.robotics.navigation.DifferentialPilot;
import lejos.robotics.navigation.Navigator;
import lejos.robotics.navigation.Waypoint;
import lejos.util.PilotProps;

public class ");
            
            #line 16 "D:\varobotprojectgroup\SPEAREDV2.0\Assets\LejosTemplates\LejosMainCodeGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ProgramName()));
            
            #line default
            #line hidden
            this.Write(@" {

	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub
		PilotProps pp = new PilotProps();
		pp.loadPersistentValues();
		float wheelDiameter = Float.parseFloat(pp.getProperty(PilotProps.KEY_WHEELDIAMETER, ""4.00""));
		float trackWidth = Float.parseFloat(pp.getProperty(PilotProps.KEY_TRACKWIDTH, ""10""));
		RegulatedMotor leftMotor = PilotProps.getMotor(pp.getProperty(PilotProps.KEY_LEFTMOTOR, ""B""));
		RegulatedMotor rightMotor = PilotProps.getMotor(pp.getProperty(PilotProps.KEY_RIGHTMOTOR, ""C""));
		boolean reverse = Boolean.parseBoolean(pp.getProperty(PilotProps.KEY_REVERSE,""true""));

		System.out.println(""Any button to start"");
		Button.waitForAnyPress();
		
		DifferentialPilot p = new DifferentialPilot(wheelDiameter, trackWidth, leftMotor, rightMotor, reverse);
		Navigator nav = new Navigator(p);
        /// Programm Start
");
            
            #line 34 "D:\varobotprojectgroup\SPEAREDV2.0\Assets\LejosTemplates\LejosMainCodeGen.tt"
 foreach (Statement s in program.statements){ 
            
            #line default
            #line hidden
            
            #line 35 "D:\varobotprojectgroup\SPEAREDV2.0\Assets\LejosTemplates\LejosMainCodeGen.tt"
        if (!(s is LejosMoveStatement)){ 
            
            #line default
            #line hidden
            this.Write("            nav.followPath();\r\n            nav = new Navigator(p);\r\n");
            
            #line 38 "D:\varobotprojectgroup\SPEAREDV2.0\Assets\LejosTemplates\LejosMainCodeGen.tt"
        }
            
            #line default
            #line hidden
            
            #line 39 "D:\varobotprojectgroup\SPEAREDV2.0\Assets\LejosTemplates\LejosMainCodeGen.tt"
        if (s is LejosMoveStatement){ 
            
            #line default
            #line hidden
            
            #line 39 "D:\varobotprojectgroup\SPEAREDV2.0\Assets\LejosTemplates\LejosMainCodeGen.tt"
var m = (LejosMoveStatement)s;
            
            #line default
            #line hidden
            this.Write("        nav.addWaypoint(new Waypoint(");
            
            #line 40 "D:\varobotprojectgroup\SPEAREDV2.0\Assets\LejosTemplates\LejosMainCodeGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(m.x));
            
            #line default
            #line hidden
            this.Write(",");
            
            #line 40 "D:\varobotprojectgroup\SPEAREDV2.0\Assets\LejosTemplates\LejosMainCodeGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(m.z));
            
            #line default
            #line hidden
            this.Write("));\r\n");
            
            #line 41 "D:\varobotprojectgroup\SPEAREDV2.0\Assets\LejosTemplates\LejosMainCodeGen.tt"
        } else { 
            
            #line default
            #line hidden
            this.Write("        /// Ignored Command\r\n");
            
            #line 43 "D:\varobotprojectgroup\SPEAREDV2.0\Assets\LejosTemplates\LejosMainCodeGen.tt"
        }
            
            #line default
            #line hidden
            
            #line 44 "D:\varobotprojectgroup\SPEAREDV2.0\Assets\LejosTemplates\LejosMainCodeGen.tt"
}
            
            #line default
            #line hidden
            this.Write("        /// Programm End\r\n        nav.followPath();\r\n\t\tSystem.out.println(\"Any bu" +
                    "tton to halt\");\r\n\t\tButton.waitForAnyPress();\r\n\t}\r\n}\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 52 "D:\varobotprojectgroup\SPEAREDV2.0\Assets\LejosTemplates\LejosMainCodeGen.tt"
 private string packageName;
        
        #line default
        #line hidden
        
        #line 53 "D:\varobotprojectgroup\SPEAREDV2.0\Assets\LejosTemplates\LejosMainCodeGen.tt"
 protected virtual string PackageName() { return this.packageName; } 
        
        #line default
        #line hidden
        
        #line 54 "D:\varobotprojectgroup\SPEAREDV2.0\Assets\LejosTemplates\LejosMainCodeGen.tt"
 public void SetPackageName(string packageName) { this.packageName = packageName; } 
        
        #line default
        #line hidden
        
        #line 56 "D:\varobotprojectgroup\SPEAREDV2.0\Assets\LejosTemplates\LejosMainCodeGen.tt"
 private string programName;
        
        #line default
        #line hidden
        
        #line 57 "D:\varobotprojectgroup\SPEAREDV2.0\Assets\LejosTemplates\LejosMainCodeGen.tt"
 protected virtual string ProgramName() { return this.programName; } 
        
        #line default
        #line hidden
        
        #line 58 "D:\varobotprojectgroup\SPEAREDV2.0\Assets\LejosTemplates\LejosMainCodeGen.tt"
 public void SetProgramName(string programName) { this.programName = programName; } 
        
        #line default
        #line hidden
        
        #line 60 "D:\varobotprojectgroup\SPEAREDV2.0\Assets\LejosTemplates\LejosMainCodeGen.tt"
 private Program program;
        
        #line default
        #line hidden
        
        #line 61 "D:\varobotprojectgroup\SPEAREDV2.0\Assets\LejosTemplates\LejosMainCodeGen.tt"
 protected virtual Program Program() { return this.program; } 
        
        #line default
        #line hidden
        
        #line 62 "D:\varobotprojectgroup\SPEAREDV2.0\Assets\LejosTemplates\LejosMainCodeGen.tt"
 public void SetProgram(Program program) { this.program = program; } 
        
        #line default
        #line hidden
        
        #line 64 "D:\varobotprojectgroup\SPEAREDV2.0\Assets\LejosTemplates\LejosMainCodeGen.tt"
 private float wheelDiameter;
        
        #line default
        #line hidden
        
        #line 65 "D:\varobotprojectgroup\SPEAREDV2.0\Assets\LejosTemplates\LejosMainCodeGen.tt"
 protected virtual float WheelDiameter() { return this.wheelDiameter; } 
        
        #line default
        #line hidden
        
        #line 66 "D:\varobotprojectgroup\SPEAREDV2.0\Assets\LejosTemplates\LejosMainCodeGen.tt"
 public void SetWheelDiameter(float wheelDiameter) { this.wheelDiameter = wheelDiameter; } 
        
        #line default
        #line hidden
        
        #line 68 "D:\varobotprojectgroup\SPEAREDV2.0\Assets\LejosTemplates\LejosMainCodeGen.tt"
 private float trackWidth;
        
        #line default
        #line hidden
        
        #line 69 "D:\varobotprojectgroup\SPEAREDV2.0\Assets\LejosTemplates\LejosMainCodeGen.tt"
 protected virtual float TrackWidth() { return this.trackWidth; } 
        
        #line default
        #line hidden
        
        #line 70 "D:\varobotprojectgroup\SPEAREDV2.0\Assets\LejosTemplates\LejosMainCodeGen.tt"
 public void SetTrackWidth(float trackWidth) { this.trackWidth = trackWidth; } 
        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public class LejosMainCodeGenBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
