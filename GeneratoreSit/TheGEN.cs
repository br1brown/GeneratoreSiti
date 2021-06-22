using GeneratoreSit.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratoreSit {
	public class TheGEN {
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
		public TheGEN(string Nameapp, string path = null) {
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
		/// <param name="_column">From 1 to 4</param>
		public void CREATEindex(bool menu, string tit = null, string content = null, int _column = 1, bool btn = true) {
			string Column, PColumn;
			if (_column < 0 && _column > 4) _column = 1;

			switch (_column) { ///il massimo è 12 per riga
				case 1:
					PColumn = "col-xs-1 col-sm-1 col-md-3";
					Column = "col-xs-10 col-sm-10 col-md-6";
					break;
				case 2:
					PColumn = "col-sm-1 col-md-2";
					Column = "col-xs-6 col-sm-5 col-md-4";
					break;
				case 3:
					PColumn = "col-md-2";
					Column = "col-xs-4 col-sm-4 col-md-2";
					break;
				case 4:
					PColumn = "";
					Column = "col-xs-3 col-sm-2 col-md-3";
					break;
				default:
					PColumn = string.Empty;
					Column = string.Empty;
					break;
			}

			string padding = "\t\t\t<div class=\"" + PColumn + "\"></div>";

			if (content == null)
				content = Resources.txt;

			if (string.IsNullOrEmpty(tit))
				tit = Name;

			string bBTN = "!--", eBTN = "--";
			if (btn) {
				bBTN = "";
				eBTN = "";
			}

			string szcolumn = "";
			for (int i = 0; i < _column; i++)
				szcolumn += "\n\t\t\t<div class=\"" + Column + " text-center shadow rounded tutto\">\n\t\t\t" + content + "\n\t\t\t</div>";

			var html = new List<string>();
			html.AddRange(new string[]{
				"<!doctype html>",

				"<html lang=\"it\">",
			});
			if (menu)
				html.AddRange(new string[]{

				"<?php",
				"$page = \"home\";",
				"if (isset($_GET[\"page\"])) {",
				"    $page = $_GET[\"page\"]; ",
				"}",
				"?>",

				});

			html.AddRange(new string[]{
				"<head>",
				"\t<meta charset=\"utf-8\">",
				"\t<meta name=\"viewport\" content=\"width=device-width, initial-scale=1\" />",

				"\t<title>"+Name+"</title>",
				"\t<meta id=\"author\" content=\""+Author+"\">",

				"\t<!-- ROBE PER IL MENU -->",
				"\t<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">",
				"\t<!-- jquery -->",
				"\t<script src=\"https://code.jquery.com/jquery-3.5.1.js\"></script>",
				"\t<script src=\"https://code.jquery.com/ui/1.12.1/jquery-ui.js\"></script>",

				"\t<!-- bootstrap -->",
				"\t<script src=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js\"></script>",
				"\t<link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css\" />",
				"\t<!-- GLI ALERT -->",
				"\t<script src=\"https://cdn.jsdelivr.net/npm/sweetalert2@10\"></script>",
				"\t<!-- Optional: include a polyfill for ES6 Promises for IE11 -->",
				"\t<script src=\"https://cdn.jsdelivr.net/npm/promise-polyfill\"></script>",

				"\t<!-- ROBA NOSTRA -->",
				"\t<link rel=\"stylesheet\" href=\"style/css.css\">",
				"\t<script src=\"js/js.js\"></script",

				"\t<style>",
				"\t\t ",
				"\t</style>",
				"</head>",
				"<body>",
				"\t<div class=\"container-fluid\">"
			});
			string funzione = "SetBottoni();";
			if (menu)
				funzione += "\n\t\tSetMenu();";
			if (!menu)
				html.AddRange(homes(tit, btn, bBTN, eBTN, padding, szcolumn));
			else {
				html.AddRange(new string[] {
					"<?php",
					"// se non va https://jsonformatter.curiousconcept.com/",
					"$menuArray = json_decode(file_get_contents(\"menu.json\"), true);",
					"",
					"if (count($menuArray) > 1) { ?>",
					"<div class=\"topnav\" id=\"ilmenu\">",
					"<?php foreach ($menuArray as $key => $value):",
					"echo \"		 <a href=# data-role=\" . $value['id'] . \" class=itemenu\";",
					"if ($page == $value['id']) {",
					"echo \" id=inizio\";",
					"}",
					"echo \">\" . $value['title'] . \"</a>\n\";",
					"endforeach; ?>",
					"<a class=\"icon\" id=\"_3punti\">",
					"<i class=\"fa fa-bars\"></i>",
					"</a>",
					"</div>",
					"<?php } else {foreach ($menuArray as $key => $value):",
					"   echo \"<a href=# data-role=\" .",
					"	   $value['id'] .",
					"	   \" class=itemenu id=inizio></a>\n\";",
					"endforeach;}",
					"foreach ($menuArray as $key => $value):",
					"echo \"\n\n<div class=menupart id=\" . $value['id'] . \">\n\";",
					"require $value['link'];",
					"echo \"\n</div>\";",
					"endforeach; ?>",
				});

				File.WriteAllBytes(Path.Combine(_Path, "menu.json"), Resources.menu);
				File.WriteAllLines(Path.Combine(_Path, "home.html"), homes(tit, btn, bBTN, eBTN, padding, szcolumn));

			}
			html.AddRange(new string[]{
			"\t</div>",
			"</body>",
			"</html>",
			"<script type=\"text/javascript\">",
			"\t$(document).ready(function () {",
			"\t\t"+ funzione,
			"\t});",
			"</script>",

			});
			if (menu)
				INDEX = Path.Combine(_Path, "index.php");
			else
				INDEX = Path.Combine(_Path, "index.html");
			File.WriteAllLines(INDEX, html.ToArray());

		}

		private List<string> homes(string tit, bool btn, string bBTN, string eBTN, string padding, string szcolumn) {
			var homes = new List<string>();
			homes.AddRange(new string[]{
				"\t\t<div class=\"row\">",
				"\t\t<div class=\"col-xs-12 col-sm-12 col-md-3 text-center\"></div>",
				"\t\t\t<div class=\"col-xs-12 col-sm-12 col-md-6 text-center shadow rounded tutto\">",
				"\t\t\t\t<h1> <b>" + tit + "</b></h1>",
				"\t\t\t\t<i>Performed by " + Author + "</i>",
				"\t\t\t</div>",
				"\t\t</div>"
			});
			if (btn)
				homes.AddRange(new string[]{
				"\t\t<"+bBTN+"div class=\"row\">",
				"\t\t\t\t<div class=\"col-xs-1 col-sm-2 col-md-3\"></div>",
				"\t\t\t\t<div class=\"col-xs-10 col-sm-8 col-md-6 shadow rounded tutto text-center\">",
				"\t\t\t\t\t<!-- https://getbootstrap.com/docs/4.0/components/buttons/ -->",
				"\t\t\t\t\t<input type=\"button\" data-type=\"success\" id=success class=\"bottone btn btn-success btn-sm\" value=\"SUCCESS\" >",
				"\t\t\t\t\t<input type=\"button\" data-type=\"warning\" id=warning class=\"bottone btn btn-warning btn-sm\" value=\"WARNING\">",
				"\t\t\t\t\t<input type=\"button\" data-type=\"info\" id=info class=\"bottone btn btn-info btn-sm\" value=\"INFO\">",
				"\t\t\t\t\t<input type=\"button\" data-type=\"error\" id=danger class=\"bottone btn btn-danger btn-sm\" value=\"DANGER\">",
				"\t\t\t\t\t<br>",
				"\t\t\t\t\t<input type=\"button\" id=primary class=\"bottone btn btn-primary btn-sm\" value=\"SUBMIT\" >",
				"\t\t\t\t\t<input type=\"button\" id=secondary class=\"bottone btn btn-secondary btn-sm\" value=\"SECONDARY\">",
				"\t\t\t\t\t<input type=\"button\" id=dark class=\"bottone btn btn-dark btn-sm\" value=\"DARK\">",
				"\t\t\t\t\t<input type=\"button\" id=light class=\"bottone btn btn-light btn-sm\" value=\"LIGHT\">",
				"\t\t\t\t\t<input type=\"button\" id=link class=\"bottone btn btn-link btn-sm\" value=\"LINK\">",
				"\t\t\t\t</div>",
				"\t\t</div"+eBTN+">",
			});
			homes.AddRange(new string[]{
			"\t\t<div class=\"row\">",
				padding + szcolumn,
				"\t\t</div>"
				});

			return homes;
		}


		public override string ToString() {
			return INDEX;
		}

		public void CREATEcss(bool menu, int bgR, int bgG, int bgB, double bgA, int font_val = 0) {
			if (bgB > 255) bgB = 255;
			if (bgG > 255) bgG = 255;
			if (bgR > 255) bgR = 255;

			if (bgB < 0) bgB = 0;
			if (bgG < 0) bgG = 0;
			if (bgR < 0) bgR = 0;


			string coloretesto = "Black";
			if (bgB <= 100 || bgG <= 100 || bgR <= 100)
				coloretesto = "White";

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
				"\tbackground-color: rgba("+bgR+", "+bgG+", "+bgB+", "+bgA+");",
				"\tfont-family: "+fonts[font_val]+";",
				"\tcolor: "+coloretesto+";",
				"\t}",
				"",
			};


			var p = Path.Combine(_Path, "style");
			if (!Directory.Exists(p))
				Directory.CreateDirectory(p);

			var pppat = Path.Combine(p, "css.css");
			File.WriteAllLines(pppat, css);
			File.AppendAllText(pppat, Resources.css);
		}

		public void CREATEjs(bool menu) {

			var js = new List<string>();
			js.AddRange(new string[]{
			"//https://sweetalert2.github.io/",
			"function SetBottoni() {",
			"\t$(\".bottone\").click(function() {",
				"\t\t$(this).blur();",
				"\t\tvar val = $(this).val()",
				"\t\tvar tipo = $(this).data(\"type\");",
				"\t\tif(tipo&& tipo!=\"\")",
				"\t\t\tswal.fire(tipo + \"" + Name + "\",val,tipo);",
				"\t\telse",
				"\t\t\tswal.fire(\"" + Name + " di " + Author + "\",val);",
				"\t});\n",
				"}\n\n",
			});
			if (menu) {
				js.AddRange(new string[] {

					"\t\tfunction SetMenu() {",
					"\t$(\".itemenu\").click(function() {",
					"\t\t$(\".menupart\").hide();",
					"\t\t$(\".itemenu\").removeClass(\"active\");",
					"\t\t$(this).addClass(\"active\");",
					"\t\tvar iddestinazione = ($(this).data(\"role\"));",
					"\t\tif(iddestinazione != \"#\") {",
					"\t\t\t$(\"#\" + iddestinazione).fadeIn();",
					"\t\t}",
					"\t});",
					"\t",
					"\t$(\"#_3punti\").click(function() {",
					"\t\t$(this).blur();",
					"\t\tif($(\"#ilmenu\").attr('class') === \"topnav\") $(\"#ilmenu\").addClass(\"responsive\");",
					"\t\telse $(\"#ilmenu\").removeClass(\"responsive\");",
					"\t});",
					"",
					"$(\"#inizio\").trigger(\"click\");",
					"}",

				});
			}
			var p = Path.Combine(_Path, "js");
			if (!Directory.Exists(p))
				Directory.CreateDirectory(p);

			File.WriteAllLines(Path.Combine(p, "js.js"), js);

		}
	}
}
