using GeneratoreSit.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratoreSit
{
    public class TheGEN
    {
        public static readonly string[] FONT = new string[]
        {
            "Georgia",
            "Palatino Linotype",
            "Times New Roman",
            "Arial",
            "Comic Sans MS",
            "Impact",
            "Lucida Sans Unicode",
            "Tahoma",
            "Trebuchet MS",
            "Verdana",
            "Courier New",
            "Lucida Console"
        };

        private string INDEX;
        public string _Path { private set; get; }
        public string Name { set; get; }
        public string Author { set; get; }
        public TheGEN(string Nameapp, string path = null)
        {
            Name = Nameapp;
            if (path == null)
                path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            _Path = path;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="_column">From 1 to 6</param>
        public void CREATEindex(string tit = null, string content = null, int _column = 1, bool btn = true)
        {
            int Column;
            int PColumn;
            if (_column <= 0 && _column > 6) _column = 1;
            switch (_column)
            {
                case 2:
                    PColumn = 3;
                    Column = 3;
                    break;
                case 3:
                    PColumn = 3;
                    Column = 2;
                    break;
                case 4:
                    PColumn = 0;
                    Column = 3;
                    break;
                case 5:
                    PColumn = 1;
                    Column = 2;
                    break;
                case 6:
                    PColumn = 0;
                    Column = 2;
                    break;
                default:
                    PColumn = 3;
                    Column = 6;
                    break;

            }

            string padding = "";
            if (PColumn > 0)
                padding = "			<div class=\"col-xs-12 col-sm-12 col-md-" + PColumn + " p-3 mb-5\"></div>";

            if (content == null)
                content = Resources.txt;

            if (string.IsNullOrEmpty(tit))
                tit= Name;

            string bBTN = "!--", eBTN = "--";
            if (btn)
            {
                bBTN = "";
                eBTN = "";
            }

            string szcolumn = "";
            for (int i = 0; i < _column; i++)
                szcolumn += "			<div class=\"col-xs-12 col-sm-12 col-md-" + Column + " text-center shadow p-3 mb-5 rounded tutto\">\n\t\t\t" + content + "\n\t\t\t</div>";

            string alert = "\"" + Name + "\",\"" + Author + "\"";
            
            var html = new string[]{
                "<!doctype html>",

                "<html lang=\"it\">",
                "<head>",
                "    <meta charset=\"utf-8\">",
                "    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\" />",

                "    <title>"+Name+"</title>",
                "    <meta id=\"author\" content=\""+Author+"\">",
                "    <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css\" />",
                "    <!-- script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js\"></script -->",
                "    <script src=\"https://code.jquery.com/jquery-1.12.4.js\"></script>",
                "    <script src=\"https://code.jquery.com/ui/1.12.1/jquery-ui.js\"></script>",
                "    <script src=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js\"></script>",

                "    <script src=\"Style/sweetalert-dev.js\"></script>",
                "    <link rel=\"stylesheet\" href=\"Style/sweetalert.css\">",
                "	<link rel=\"stylesheet\" href=\"Style/css.css\">",

                "    <style>",
                "        ",
                "    </style>",
                "</head>",

                "<body>",
                "    <div class=\"container-fluid\">",
                "		<div class=\"row\">",
                "		<div class=\"col-xs-12 col-sm-12 col-md-3 text-center p-3 mb-5\"></div>",
                "			<div class=\"col-xs-12 col-sm-12 col-md-6 text-center shadow p-3 mb-5 rounded tutto\">",
                "				<h1> <b>"+tit+"</b></h1>",
                "				 <i>"+Author+"</i>",
                "			</div>",
                "		</div>",
                "		<"+bBTN+"div class=\"row\">",
                "                <div class=\"col-xs-12 col-sm-12 col-md-4\"></div>",
                "                <div class=\"col-xs-12 col-sm-12 col-md-4 text-center shadow p-3 mb-5 rounded tutto\">",
                "                    <input type=\"button\" id=primary class=\"btn btn-primary\" value=\"SUBMIT\" >",
                "                    <input type=\"button\" id=success class=\"btn btn-success\" value=\"SUCCESS\" >",
                "                    <input type=\"button\" id=warning class=\"btn btn-warning\" value=\"WARNING\">",
                "                    <input type=\"button\" id=info class=\"btn btn-info\" value=\"INFO\">",
                "                    <input type=\"button\" id=danger class=\"btn btn-danger\" value=\"DANGER\">",
                "                </div>",
                "		</div"+eBTN+">",
                "		<div class=\"row\">",
                padding,
                szcolumn,
                "		</div>",
                "    </div>",
                "</body>",
                "</html>",
                "<script type=\"text/javascript\">",
                "//https://sweetalert.js.org/guides/",
                "    $(document).ready(function () {",
                "       $(\"#danger\").click(function () {",
                "          swal("+ alert +",\"error\");",
                "       });",
                "       $(\"#info\").click(function () {",
                "          swal("+ alert +",\"info\");",
                "       });",
                "       $(\"#warning\").click(function () {",
                "          swal("+ alert +",\"warning\");",
                "       });",
                "       $(\"#success\").click(function () {",
                "          swal("+ alert +",\"success\");",
                "       });",
                "       $(\"#primary\").click(function () {",
                "          swal(\""+Name+"\");",
                "       });",
                "    });",
                "</script>",

            };
            INDEX = Path.Combine(_Path, "index.html");
            File.WriteAllLines(INDEX, html);
        }

        public void CREATEsweetalert()
        {
            var p = Path.Combine(_Path, "Style");
            if (!Directory.Exists(p))
                Directory.CreateDirectory(p);

            File.WriteAllText(Path.Combine(p, "sweetalert.css"), Resources.sweetalert);
        }

        public override string ToString()
        {
            return INDEX;
        }

        public void CREATEcss(int bgR, int bgG, int bgB, double bgA, int font_val = 0)
        {
            if (bgB > 255) bgB = 255;
            if (bgG > 255) bgG = 255;
            if (bgR > 255) bgR = 255;

            if (bgB < 0) bgB = 0;
            if (bgG < 0) bgG = 0;
            if (bgR < 0) bgR = 0;

            var fonts = new string[] {
                "Georgia, serif",
                "\"Palatino Linotype\", \"Book Antiqua\", Palatino, serif",
                "\"Times New Roman\", Times, serif",
                "Arial, Helvetica, sans-serif",
                "\"Comic Sans MS\", cursive, sans-serif",
                "Impact, Charcoal, sans-serif",
                "\"Lucida Sans Unicode\", \"Lucida Grande\", sans-serif",
                "Tahoma, Geneva, sans-serif",
                "\"Trebuchet MS\", Helvetica, sans-serif",
                "Verdana, Geneva, sans-serif",
                "\"Courier New\", Courier, monospace",
                "\"Lucida Console\", Monaco, monospace"
            };

            if ((font_val < 0) && font_val > fonts.Length)
                font_val = 0;

            var css = new string[]{
                "body {",
                "	background-color: rgba("+bgR+", "+bgG+", "+bgB+", "+bgA+");",
                "	font-family: "+fonts[font_val]+";",
                "	}",
                "",
                ".tutto {",
                "	background-color: rgba(255, 255, 255, 0.5);",
                "	border: 1px solid;",
                "	padding: 10px;",
                "	box-shadow: 5px 10px 8px #888888;",
                "	vertical-align: middle;",
                "}",
                "",
                ".row {",
                "	padding-top: 10px;",
                "}"
            };
            var p = Path.Combine(_Path, "Style");
            if (!Directory.Exists(p))
                Directory.CreateDirectory(p);

            File.WriteAllLines(Path.Combine(p, "css.css"), css);
        }

        public void CREATEsweetalertJS()
        {
            var p = Path.Combine(_Path, "Style");
            if (!Directory.Exists(p))
                Directory.CreateDirectory(p);

            File.WriteAllText(Path.Combine(p, "sweetalert-dev.js"), Resources.sweetalert_dev);
        }
    }
}
