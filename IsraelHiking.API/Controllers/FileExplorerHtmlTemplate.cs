﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace IsraelHiking.API.Controllers
{
    using System.Linq;

    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\Github\IsraelHikingMap\Site\IsraelHiking.API\Controllers\FileExplorerHtmlTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class FileExplorerHtmlTemplate : FileExplorerHtmlTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\n<html>\r\n<head prefix=\"og: http://ogp.me/ns#\">\r\n    <meta content=\"text/html;cha" +
                    "rset=utf-8\" http-equiv=\"Content-Type\">\r\n    <meta content=\"utf-8\" http-equiv=\"en" +
                    "coding\">\r\n    <meta content=\"IE=edge, chrome=1\" http-equiv=\"X-UA-Compatible\" />\r" +
                    "\n    <meta property=\"og:site_name\" content=\"IsraelHiking.OSM.org.il\" />\r\n    <me" +
                    "ta property=\"og:url\" content=\"http://israelhiking.osm.org.il/\" />\r\n    <meta pro" +
                    "perty=\"og:type\" content=\"website\" />\r\n    <meta property=\"og:title\" content=\"Isr" +
                    "ael Hiking Map\" />\r\n    <meta property=\"og:image\" content=\"http://israelhiking.o" +
                    "sm.org.il/content/images/favicons/android-chrome-192x192.png\" />\r\n    <meta prop" +
                    "erty=\"og:image:url\" content=\"http://israelhiking.osm.org.il/content/images/favic" +
                    "ons/android-chrome-192x192.png\" />\r\n    <meta property=\"og:image:secure_url\" con" +
                    "tent=\"https://israelhiking.osm.org.il/content/images/favicons/android-chrome-192" +
                    "x192.png\" />\r\n\t<meta property=\"og:image:width\" content=\"192\" />\r\n    <meta prope" +
                    "rty=\"og:image:height\" content=\"192\" />\r\n    <meta property=\"og:description\" cont" +
                    "ent=\"בין אם אתם יוצאים לטיול רגלי, רכיבה על אופניים או נסיעה ברכב שטח, כאן תוכלו" +
                    " למצוא כל מה שאתם צריכים על מנת לתכנן את הביקור הבא שלכם בטבע.\" />\r\n    <meta na" +
                    "me=\"title\" content=\"Israel Hiking Map\" />\r\n    <meta name=\"description\" content=" +
                    "\"בין אם אתם יוצאים לטיול רגלי, רכיבה על אופניים או נסיעה ברכב שטח, כאן תוכלו למצ" +
                    "וא כל מה שאתם צריכים על מנת לתכנן את הביקור הבא שלכם בטבע.\" />\r\n    <meta name=\"" +
                    "keyword\" content=\"hike,bike,outdoor,israel hiking,map,navigation,route planning," +
                    "nominatim,סימון שבילים,אופניים,מפה,ניווט,שטח,טיול,מטיבי לכת,ג\'יפים,רכיבה,הליכה,ט" +
                    "בע\" />\r\n    <meta name=\"robot\" content=\"index,follow\" />\r\n    <meta name=\"msappl" +
                    "ication-TileColor\" content=\"#2b5797\">\r\n    <meta name=\"msapplication-TileImage\" " +
                    "content=\"/content/images/favicons/mstile-144x144.png\">\r\n    <meta name=\"msapplic" +
                    "ation-config\" content=\"/content/images/favicons/browserconfig.xml\">\r\n    <meta n" +
                    "ame=\"theme-color\" content=\"#0a42bb\">\r\n    <meta name=\"viewport\" content=\"width=d" +
                    "evice-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no\" />\r\n    <ti" +
                    "tle>Israel Hiking Map - ");
            
            #line 31 "D:\Github\IsraelHikingMap\Site\IsraelHiking.API\Controllers\FileExplorerHtmlTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(FileExplorerViewModel.CurrentEntryPath.Any() ? FileExplorerViewModel.CurrentEntryPath.Last().Name : "Invalid Folder"));
            
            #line default
            #line hidden
            this.Write("</title>\r\n    <!-- Favicons courtesy of http://realfavicongenerator.net/ -->\r\n   " +
                    " <link rel=\"apple-touch-icon\" sizes=\"57x57\" href=\"/content/images/favicons/apple" +
                    "-touch-icon-57x57.png\">\r\n    <link rel=\"apple-touch-icon\" sizes=\"60x60\" href=\"/c" +
                    "ontent/images/favicons/apple-touch-icon-60x60.png\">\r\n    <link rel=\"apple-touch-" +
                    "icon\" sizes=\"72x72\" href=\"/content/images/favicons/apple-touch-icon-72x72.png\">\r" +
                    "\n    <link rel=\"apple-touch-icon\" sizes=\"76x76\" href=\"/content/images/favicons/a" +
                    "pple-touch-icon-76x76.png\">\r\n    <link rel=\"apple-touch-icon\" sizes=\"114x114\" hr" +
                    "ef=\"/content/images/favicons/apple-touch-icon-114x114.png\">\r\n    <link rel=\"appl" +
                    "e-touch-icon\" sizes=\"120x120\" href=\"/content/images/favicons/apple-touch-icon-12" +
                    "0x120.png\">\r\n    <link rel=\"apple-touch-icon\" sizes=\"144x144\" href=\"/content/ima" +
                    "ges/favicons/apple-touch-icon-144x144.png\">\r\n    <link rel=\"apple-touch-icon\" si" +
                    "zes=\"152x152\" href=\"/content/images/favicons/apple-touch-icon-152x152.png\">\r\n   " +
                    " <link rel=\"apple-touch-icon\" sizes=\"180x180\" href=\"/content/images/favicons/app" +
                    "le-touch-icon-180x180.png\">\r\n    <link rel=\"icon\" type=\"image/png\" href=\"/conten" +
                    "t/images/favicons/favicon-32x32.png\" sizes=\"32x32\">\r\n    <link rel=\"icon\" type=\"" +
                    "image/png\" href=\"/content/images/favicons/android-chrome-192x192.png\" sizes=\"192" +
                    "x192\">\r\n    <link rel=\"icon\" type=\"image/png\" href=\"/content/images/favicons/fav" +
                    "icon-96x96.png\" sizes=\"96x96\">\r\n    <link rel=\"icon\" type=\"image/png\" href=\"/con" +
                    "tent/images/favicons/favicon-16x16.png\" sizes=\"16x16\">\r\n    <link rel=\"manifest\"" +
                    " href=\"/content/images/favicons/manifest.json\">\r\n    <link rel=\"mask-icon\" href=" +
                    "\"/content/images/favicons/safari-pinned-tab.svg\" color=\"#0a42bb\">\r\n    <link rel" +
                    "=\"shortcut icon\" href=\"/content/images/favicons/favicon.ico\" type=\"image/x-icon\"" +
                    ">\r\n\t<!-- Stylesheets -->\r\n\t<link rel=\"stylesheet\" href=\"/content/bootstrap.min.c" +
                    "ss\" />\r\n\t<link rel=\"stylesheet\" href=\"/content/font-awesome.min.css\" />\r\n</head>" +
                    "\r\n<body>\r\n\t<div class=\'container\'>\r\n\t\t<h3>Index of \r\n\t\t");
            
            #line 56 "D:\Github\IsraelHikingMap\Site\IsraelHiking.API\Controllers\FileExplorerHtmlTemplate.tt"
foreach(var header in FileExplorerViewModel.CurrentEntryPath)
		{
            
            #line default
            #line hidden
            this.Write("\t\t\t<a href=\'");
            
            #line 58 "D:\Github\IsraelHikingMap\Site\IsraelHiking.API\Controllers\FileExplorerHtmlTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(header.Link));
            
            #line default
            #line hidden
            this.Write("\'>");
            
            #line 58 "D:\Github\IsraelHikingMap\Site\IsraelHiking.API\Controllers\FileExplorerHtmlTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(header.Name));
            
            #line default
            #line hidden
            this.Write("</a>\r\n\t\t");
            
            #line 59 "D:\Github\IsraelHikingMap\Site\IsraelHiking.API\Controllers\FileExplorerHtmlTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\t\t</h3>\r\n\t\t<table class=\'table table-hover\'>\r\n\t\t\t<thead>\r\n\t\t\t<tr>\r\n\t\t\t\t<th></th>\r" +
                    "\n\t\t\t\t<th>Name</th>\r\n\t\t\t\t<th>Size</th>\r\n\t\t\t\t<th>Last Modified</th>\r\n\t\t\t</tr>\r\n\t\t\t" +
                    "</thead>\r\n\t\t\t<tbody>\r\n\t\t\t");
            
            #line 71 "D:\Github\IsraelHikingMap\Site\IsraelHiking.API\Controllers\FileExplorerHtmlTemplate.tt"
foreach (var item in FileExplorerViewModel.Entries)
			{
            
            #line default
            #line hidden
            this.Write("\t\t\t\t<tr>\r\n\t\t\t\t\t");
            
            #line 74 "D:\Github\IsraelHikingMap\Site\IsraelHiking.API\Controllers\FileExplorerHtmlTemplate.tt"
if (item.Name.EndsWith("/")) 
					{
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\t<td><i class=\'fa fa-lg fa-folder-open\'></i></td>\r\n\t\t\t\t\t");
            
            #line 77 "D:\Github\IsraelHikingMap\Site\IsraelHiking.API\Controllers\FileExplorerHtmlTemplate.tt"
} else if (item.Name.EndsWith("xml")) {
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\t<td><i class=\'fa fa-lg fa-file-code-o\'></i></td>\r\n\t\t\t\t\t");
            
            #line 79 "D:\Github\IsraelHikingMap\Site\IsraelHiking.API\Controllers\FileExplorerHtmlTemplate.tt"
} else if (item.Name.EndsWith("zip")) {
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\t<td><i class=\'fa fa-lg fa-file-zip-o\'></i></td>\r\n\t\t\t\t\t");
            
            #line 81 "D:\Github\IsraelHikingMap\Site\IsraelHiking.API\Controllers\FileExplorerHtmlTemplate.tt"
} else if (item.Name.EndsWith("png")) {
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\t<td><i class=\'fa fa-lg fa-file-image-o\'></i></td>\r\n\t\t\t\t\t");
            
            #line 83 "D:\Github\IsraelHikingMap\Site\IsraelHiking.API\Controllers\FileExplorerHtmlTemplate.tt"
} else {
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\t<td><i class=\'fa fa-lg fa-file-text-o\'></i></td>\r\n\t\t\t\t\t");
            
            #line 85 "D:\Github\IsraelHikingMap\Site\IsraelHiking.API\Controllers\FileExplorerHtmlTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t<td><a href=\"");
            
            #line 86 "D:\Github\IsraelHikingMap\Site\IsraelHiking.API\Controllers\FileExplorerHtmlTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Link));
            
            #line default
            #line hidden
            this.Write("\">");
            
            #line 86 "D:\Github\IsraelHikingMap\Site\IsraelHiking.API\Controllers\FileExplorerHtmlTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Name));
            
            #line default
            #line hidden
            this.Write("</a></td>\r\n\t\t\t\t\t");
            
            #line 87 "D:\Github\IsraelHikingMap\Site\IsraelHiking.API\Controllers\FileExplorerHtmlTemplate.tt"
if (item.Name.EndsWith("/")) {
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\t<td></td>\r\n\t\t\t\t\t");
            
            #line 89 "D:\Github\IsraelHikingMap\Site\IsraelHiking.API\Controllers\FileExplorerHtmlTemplate.tt"
} else {
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\t<td>");
            
            #line 90 "D:\Github\IsraelHikingMap\Site\IsraelHiking.API\Controllers\FileExplorerHtmlTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetSizeString(item.Size)));
            
            #line default
            #line hidden
            this.Write("</td>\r\n\t\t\t\t\t");
            
            #line 91 "D:\Github\IsraelHikingMap\Site\IsraelHiking.API\Controllers\FileExplorerHtmlTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t<td>");
            
            #line 92 "D:\Github\IsraelHikingMap\Site\IsraelHiking.API\Controllers\FileExplorerHtmlTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.LastModified.ToString("dd/MM/yyyy HH:mm")));
            
            #line default
            #line hidden
            this.Write("</td>\r\n\t\t\t\t</tr>\r\n\t\t\t");
            
            #line 94 "D:\Github\IsraelHikingMap\Site\IsraelHiking.API\Controllers\FileExplorerHtmlTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\t\t\t</tbody>\r\n\t\t</table>\r\n\t</div>\r\n</body>\r\n</html>");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public class FileExplorerHtmlTemplateBase
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
