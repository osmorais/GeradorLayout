using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;


namespace Alfabeto_Digital
{
    class Program
	{
		public struct letra
		{
			public char predef;
			public char predef2;
			public string linha1;
			public string linha2;
			public string linha3;
			public string linha4;
			public string linha5;
			public string linha6;
			public string linha7;
			public string linha8;
		}
		private static string EntradaString(string mensagemUsuario)
		{
			string saida = " ";
			double aux = 0;
			bool erro = false;

			do
			{
				if (erro) Console.WriteLine("---\nErro!\n");
				Console.Write(mensagemUsuario);
				saida = Console.ReadLine();
				if (String.IsNullOrWhiteSpace(saida) ||
					double.TryParse(saida, out aux) ||
					saida.Length < 2 ||
					saida.Contains(";")) erro = true;
				else erro = false;
			} while (erro);

			return saida;
		}
		private static char EntradaCaracter(string mensagemUsuario)
		{
			char saida = ' ';
			bool erro = false;

			do
			{
				if (erro) Console.WriteLine("---\nErro!\n");
				Console.Write(mensagemUsuario);
				erro = !char.TryParse(Console.ReadLine(), out saida);
				if (!Char.IsLetter(saida)) erro = true;
			} while (erro);

			return Char.ToLowerInvariant(saida);
		}
		static void Main(string[] args)
		{
			inicio();
			string pathAtivo = "";
			string FileName = "";
			string pathRoot = @"C:\Users\osmar.junior\Desktop\comando layout";
			if(!File.Exists(pathRoot)) System.IO.Directory.CreateDirectory(pathRoot);
			letra[] lt = new letra[27];
			alfabeto(lt);
			selecionarOP(ref pathAtivo, ref FileName, ref pathRoot, lt);
			gravCmdLayout(pathAtivo, lt, 1);
			Console.ReadKey();
		}

		private static void inicio()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Title = "GERADOR DE LAYOUT 1.0";
			Console.Write("\n____ASASASASAS__"); Console.Write("BVBVBVBVBVBVBV__"); Console.Write("_QQWQWQWQWQW____"); Console.Write("_____DSDSDS_____"); Console.Write("_QQWQWQWQWQW____"); Console.Write("\n__ASASA___ASASA_"); Console.Write("_VBVBV___VBVBVB_"); Console.Write("__QWQWQWQWQWQW__"); Console.Write("___SDSDSDSDSD___"); Console.Write("__QWQWQWQWQWQW__"); Console.Write("\n_ASASA__________"); Console.Write("_VBVBV__________"); Console.Write("__QWQW____QWQWQ_"); Console.Write("__SSDSD__DSDSD__"); Console.Write("__QWQW____QWQWQ_"); Console.Write("\n_ASASA__________"); Console.Write("_VBVBVBVBVB_____"); Console.Write("__QWQW___QWQWQ__"); Console.Write("_SDSDD____SDSDD_"); Console.Write("__QWQW___QWQWQ__"); Console.Write("\n_ASASA_SASASASA_"); Console.Write("_VBVBVBVBVB_____"); Console.Write("__QWQWQWQWQWQ___"); Console.Write("_SDSDSSDSDSDSDS_"); Console.Write("__QWQWQWQWQWQ___"); Console.Write("\n_ASASA_SA_ASASA_"); Console.Write("_VBVBV__________"); Console.Write("__QWQWQWQWQQ____"); Console.Write("_DSDSDDSDSSDSDS_"); Console.Write("__QWQWQWQWQQ____"); Console.Write("\n__ASASA___SASAS_"); Console.Write("_VBVBV___VBVBVB_"); Console.Write("__QWQW___QWQWQ__"); Console.Write("_DSDSD____SDSDS_"); Console.Write("__QWQW___QWQWQ__"); Console.Write("\n____SASASASASA__"); Console.Write("BVBVBVBVBVBVBV__"); Console.Write("_WQWQW____QWQWQW"); Console.Write("_DSDSD____SDSDS_"); Console.Write("_WQWQW____QWQWQW");
			Console.WriteLine("\n");
			Console.Write("\n_CXCXCXC_________"); Console.Write("_____DSDSDS_____"); Console.Write("_GHGH_______GHGH_"); Console.Write("_____MLMLMLM____"); Console.Write("_KLKL______LKLK_"); Console.Write("_DFDFDFDFDDFFD_"); Console.Write("\n__XCXCX__________"); Console.Write("___SDSDSDSDSD___"); Console.Write("__GHGH_____GHGH__"); Console.Write("___MLMLMLMMLML__"); Console.Write("_KLKL______LKLK_"); Console.Write("_DFDFDFDFDDFFD_"); Console.Write("\n__XCXCX__________"); Console.Write("__SSDSD__DSDSD__"); Console.Write("___GHGH___GHGH___"); Console.Write("__MLML_____MLML_"); Console.Write("_KLKL______LKLK_"); Console.Write("_____DFFDF_____"); Console.Write("\n__XCXCX__________"); Console.Write("_SDSDD____SDSDD_"); Console.Write("____GHGH_GHGH____"); Console.Write("_MLML_______MLML"); Console.Write("_KLKL______LKLK_"); Console.Write("_____DFFDF_____"); Console.Write("\n__XCXCX__________"); Console.Write("_SDSDSSDSDSDSDS_"); Console.Write("_____GHGHGHG_____"); Console.Write("_MLML_______MLML"); Console.Write("_KLKL______LKLK_"); Console.Write("_____DFFDF_____"); Console.Write("\n__XCXCX___XCXCXC_"); Console.Write("_DSDSDDSDSSDSDS_"); Console.Write("______HGHGH______"); Console.Write("__MLML_____MLML_"); Console.Write("_KLKLK____KLKLK_"); Console.Write("_____DFFDF_____"); Console.Write("\n__XCXCX____XCXC__"); Console.Write("_DSDSD____SDSDS_"); Console.Write("______HGHGH______"); Console.Write("___LMLMLMLMLML__"); Console.Write("__KKLKLKKLKLKL__"); Console.Write("_____DFFDF_____"); Console.Write("\n_CXCXCXCXCXCXCX__"); Console.Write("_DSDSD____SDSDS_"); Console.Write("______HGHGH______"); Console.Write("_____LMLMLML____"); Console.Write("____LKKKLKLK____"); Console.Write("____FDFFDFD____");
			Console.WriteLine("\n\n\t\t\tCopyright Oficial SysInfo ©");

			Console.WriteLine("\n\t\tPressione qualquer tecla para continuar... ");

			Console.ReadKey();
			Console.ResetColor();
		}

		private static void selecionarOP(ref string pathAtivo, ref string FileName, ref string pathRoot,letra [] lt)
		{
			bool sair = false;
			bool excluir = false;
			do
			{

				Console.Clear();
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("\n______________________________________________________________________________________________________");
				if (pathAtivo != "" && excluir != true) Console.WriteLine("\nArquivo Selecionado: " + pathAtivo);
				else Console.WriteLine("\nNenhum arquivo selecionado!");
				home();
				char alternativa = ' ';
				bool erroAux = false;
				do
				{
					if (erroAux) Console.WriteLine("---\nSelecione uma opção da legenda!\n");
					alternativa = EntradaCaracter("\n >>> ");
					if (alternativa != 'a' && alternativa != 'b' && alternativa != 'c') erroAux = true;
					else erroAux = false;
				} while (erroAux);
				switch (alternativa)
				{
					case 'a':
						excluir = false;
						criarLayout(pathRoot, ref pathAtivo, ref FileName, lt);
						break;
					case 'b':
						excluirLayout(pathRoot, ref pathAtivo, ref excluir);
						break;
					case 'c':
						sair = true;
						break;
				}
			} while (sair != true);
		}

		private static void home()
		{
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("______________________________________________________________________________________________________");
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("                                   A) CRIAR NOVO LAYOUT                                               ");
			Console.WriteLine("                                   B) EXCLUIR LAYOUT                                                  ");
			Console.WriteLine("                                   C) SAIR                                                            ");
			Console.WriteLine("______________________________________________________________________________________________________");
			Console.ResetColor();
		}

		private static void excluirLayout(string pathRoot, ref string pathAtivo, ref bool excluir)
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("______________________________________________________________________________________________________");
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("                                        DELETAR ARQUIVOS                                              ");
			Console.WriteLine("______________________________________________________________________________________________________");
			Console.ResetColor();
			string FileName = EntradaString("\nEntre com o nome do arquivo que deseja deletar: ");
			string excluiPath = pathRoot + "/" + FileName + ".txt";


			if (File.Exists(excluiPath))
			{
				File.Delete(excluiPath);
				if (excluiPath == pathAtivo) pathAtivo = pathRoot;
				excluir = true;
				ApresentacaoVinheta("Deletando Arquivo!",1);
			}
			else
			{
				Console.WriteLine("\n______________________________________________________________________________________________________");
				Console.WriteLine("Esse arquivo não existe dentro desse diretório!");
				Console.Write("\n\nPressione enter para continuar...");
				Console.ReadKey();
				excluir = false;
			}
		}

		private static void criarLayout(string pathRoot, ref string pathAtivo, ref string FileName, letra [] lt)
		{
			char resp = ' ';
			do
			{
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("______________________________________________________________________________________________________");
				Console.BackgroundColor = ConsoleColor.DarkCyan;
				Console.WriteLine("                                         CRIAR LAYOUT                                                 ");
				Console.WriteLine("______________________________________________________________________________________________________");
				Console.ResetColor();
				FileName = EntradaString("\nEntre com o nome do arquivo: ");
				pathAtivo = pathRoot + "/" + FileName + ".txt";

				if (!File.Exists(pathAtivo))
				{
					ApresentacaoVinheta("Criando o Arquivo!",1);
					FileStream arquivo = new FileStream(pathAtivo, FileMode.CreateNew, FileAccess.ReadWrite);
					arquivo.Close();
					resp = 'a';
				}
				else
				{
					bool erroAux = false;
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("\n\nEssa pasta já contém um arquivo chamado '" + FileName + ".txt'");
					Console.WriteLine("______________________________________________________________________________________________________");
					Console.BackgroundColor = ConsoleColor.DarkCyan;
					Console.WriteLine("A) Substituir o arquivo existente                                                                     ");
					Console.WriteLine("B) Renomear esse arquivo                                                                              ");
					Console.WriteLine("C) Abrir o arquivo '" + FileName + ".txt'                                                             \t\t  ");
					Console.WriteLine("______________________________________________________________________________________________________");
					Console.ResetColor();

					do
					{
						if (erroAux) Console.WriteLine("---\nSelecione uma opção da legenda!\n");
						resp = EntradaCaracter("\n >>> ");
						if (resp != 'a' && resp != 'b' && resp != 'c') erroAux = true;
						else erroAux = false;
					} while (erroAux);

					if (resp == 'a')
					{
						File.Delete(pathAtivo);
						FileStream arquivo = new FileStream(pathAtivo, FileMode.CreateNew, FileAccess.ReadWrite);
						arquivo.Close();
						ApresentacaoVinheta("Substituindo no arquivo de destino!",1);
					}
					if(resp == 'c')
					{
						ApresentacaoVinheta("Selecionando o Arquivo!",1);
					}
				}
			} while (resp != 'a' && resp != 'c');

			gravCmdLayout(pathAtivo,lt,0);
		}

		private static void gravCmdLayout(string pathAtivo,letra[] lt,int menu)
		{
			string palavra = "";
			int numLetras = 0;

			by(lt, menu, ref palavra, ref numLetras);

			if (menu == 0)
			{
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("______________________________________________________________________________________________________");
				Console.BackgroundColor = ConsoleColor.DarkCyan;
				Console.WriteLine("                                         CRIAR LAYOUT                                                 ");
				Console.WriteLine("______________________________________________________________________________________________________");
				Console.ResetColor();
				palavra = EntradaString("Digite o layout que deseja gerar: ");
				numLetras = palavra.Length;
				exibicaoLayout(lt, palavra, numLetras);
				Console.WriteLine("\n\n\n\t\tPressione qualquer tecla para continuar...");
				Console.ReadKey();

				FileStream arquivo = new FileStream(pathAtivo, FileMode.Open, FileAccess.ReadWrite);
				StreamWriter layout = new StreamWriter(arquivo);
				for (int linha = 1; linha <= 8; linha++)
				{
					//LETRA DIGITADA
					for (int posicaolt = 0; posicaolt < numLetras; posicaolt++)
					{
						//LETRAS DO ALFABETO
						for (int z = 0; z < 27; z++)
						{
							if ((palavra[posicaolt] == lt[z].predef) || (palavra[posicaolt] == lt[z].predef2))
							{
								if ((linha == 1) && (posicaolt == 0)) layout.Write("Console.Write(\"\\n" + lt[z].linha1 + "\");");
								else if (linha == 1) layout.Write("Console.Write(\"" + lt[z].linha1 + "\");");
								if ((linha == 2) && (posicaolt == 0)) layout.Write("Console.Write(\"\\n" + lt[z].linha2 + "\");");
								else if (linha == 2 && posicaolt != 0) layout.Write("Console.Write(\"" + lt[z].linha2 + "\");");
								if ((linha == 3) && (posicaolt == 0)) layout.Write("Console.Write(\"\\n" + lt[z].linha3 + "\");");
								else if (linha == 3 && posicaolt != 0) layout.Write("Console.Write(\"" + lt[z].linha3 + "\");");
								if ((linha == 4) && (posicaolt == 0)) layout.Write("Console.Write(\"\\n" + lt[z].linha4 + "\");");
								else if (linha == 4 && posicaolt != 0) layout.Write("Console.Write(\"" + lt[z].linha4 + "\");");
								if ((linha == 5) && (posicaolt == 0)) layout.Write("Console.Write(\"\\n" + lt[z].linha5 + "\");");
								else if (linha == 5 && posicaolt != 0) layout.Write("Console.Write(\"" + lt[z].linha5 + "\");");
								if ((linha == 6) && (posicaolt == 0)) layout.Write("Console.Write(\"\\n" + lt[z].linha6 + "\");");
								else if (linha == 6 && posicaolt != 0) layout.Write("Console.Write(\"" + lt[z].linha6 + "\");");
								if ((linha == 7) && (posicaolt == 0)) layout.Write("Console.Write(\"\\n" + lt[z].linha7 + "\");");
								else if (linha == 7 && posicaolt != 0) layout.Write("Console.Write(\"" + lt[z].linha7 + "\");");
								if ((linha == 8) && (posicaolt == 0)) layout.Write("Console.Write(\"\\n" + lt[z].linha8 + "\");");
								else if (linha == 8 && posicaolt != 0) layout.Write("Console.Write(\"" + lt[z].linha8 + "\");");
							}
						}
					}
				}
				layout.WriteLine("\nConsole.WriteLine(\"\\n\\n\\t\\t\\tCopyright Oficial SysInfo ©\");");
				layout.WriteLine("\nConsole.WriteLine(\"\\n\\t\\tPressione qualquer tecla para continuar... \");");
				layout.WriteLine("\nConsole.ReadKey();");
				layout.Close();
				arquivo.Close();
				ApresentacaoVinheta("Gerando Layout. Aguarde...", 1);
				Console.WriteLine("\n\n\n\t\tLayout Gerado com Sucesso!!\n\tPressione qualquer tecla para continuar...");
				Console.ReadKey();
			}
		}

		private static void exibicaoLayout(letra[] lt, string palavra, int numLetras)
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			//NUMERO DE LINHAS
			for (int linha = 1; linha <= 8; linha++)
			{
				//LETRA DIGITADA
				for (int posicaolt = 0; posicaolt < numLetras; posicaolt++)
				{
					//LETRAS DO ALFABETO
					for (int z = 0; z < 27; z++)
					{
						if ((palavra[posicaolt] == lt[z].predef) || (palavra[posicaolt] == lt[z].predef2))
						{
							if ((linha == 1) && (posicaolt == 0)) Console.Write("\n\n\n" + lt[z].linha1 + "");
							else if (linha == 1) Console.Write(lt[z].linha1 + "");
							if ((linha == 2) && (posicaolt == 0)) Console.Write("\n" + lt[z].linha2 + "");
							else if (linha == 2 && posicaolt != 0) Console.Write(lt[z].linha2 + "");
							if ((linha == 3) && (posicaolt == 0)) Console.Write("\n" + lt[z].linha3 + "");
							else if (linha == 3 && posicaolt != 0) Console.Write(lt[z].linha3 + "");
							if ((linha == 4) && (posicaolt == 0)) Console.Write("\n" + lt[z].linha4 + "");
							else if (linha == 4 && posicaolt != 0) Console.Write(lt[z].linha4 + "");
							if ((linha == 5) && (posicaolt == 0)) Console.Write("\n" + lt[z].linha5 + "");
							else if (linha == 5 && posicaolt != 0) Console.Write(lt[z].linha5 + "");
							if ((linha == 6) && (posicaolt == 0)) Console.Write("\n" + lt[z].linha6 + "");
							else if (linha == 6 && posicaolt != 0) Console.Write(lt[z].linha6 + "");
							if ((linha == 7) && (posicaolt == 0)) Console.Write("\n" + lt[z].linha7 + "");
							else if (linha == 7 && posicaolt != 0) Console.Write(lt[z].linha7 + "");
							if ((linha == 8) && (posicaolt == 0)) Console.Write("\n" + lt[z].linha8 + "");
							else if (linha == 8 && posicaolt != 0) Console.Write(lt[z].linha8 + "");
						}
					}
				}
			}
			Console.WriteLine("\n\n\t\t\tCopyright Oficial SysInfo ©");
			Console.ResetColor();
		}

		private static void by(letra[] lt, int menu, ref string palavra, ref int numLetras)
		{
			if (menu == 1)
			{
				ApresentacaoVinheta("Saindo do programa!",1);
				palavra = "OSMAR";
				numLetras = palavra.Length;
				Console.ForegroundColor = ConsoleColor.Cyan;
				//NUMERO DE LINHAS
				for (int linha = 1; linha <= 8; linha++)
				{
					//LETRA DIGITADA
					for (int posicaolt = 0; posicaolt < numLetras; posicaolt++)
					{
						//LETRAS DO ALFABETO
						for (int z = 0; z < 27; z++)
						{
							if (palavra[posicaolt] == lt[z].predef)
							{
								if ((linha == 1) && (posicaolt == 0)) Console.Write("\n\n\n" + lt[z].linha1 + "");
								else if (linha == 1) Console.Write(lt[z].linha1 + "");
								if ((linha == 2) && (posicaolt == 0)) Console.Write("\n" + lt[z].linha2 + "");
								else if (linha == 2 && posicaolt != 0) Console.Write(lt[z].linha2 + "");
								if ((linha == 3) && (posicaolt == 0)) Console.Write("\n" + lt[z].linha3 + "");
								else if (linha == 3 && posicaolt != 0) Console.Write(lt[z].linha3 + "");
								if ((linha == 4) && (posicaolt == 0)) Console.Write("\n" + lt[z].linha4 + "");
								else if (linha == 4 && posicaolt != 0) Console.Write(lt[z].linha4 + "");
								if ((linha == 5) && (posicaolt == 0)) Console.Write("\n" + lt[z].linha5 + "");
								else if (linha == 5 && posicaolt != 0) Console.Write(lt[z].linha5 + "");
								if ((linha == 6) && (posicaolt == 0)) Console.Write("\n" + lt[z].linha6 + "");
								else if (linha == 6 && posicaolt != 0) Console.Write(lt[z].linha6 + "");
								if ((linha == 7) && (posicaolt == 0)) Console.Write("\n" + lt[z].linha7 + "");
								else if (linha == 7 && posicaolt != 0) Console.Write(lt[z].linha7 + "");
								if ((linha == 8) && (posicaolt == 0)) Console.Write("\n" + lt[z].linha8 + "");
								else if (linha == 8 && posicaolt != 0) Console.Write(lt[z].linha8 + "");
							}
						}
					}
				}
				Console.WriteLine("\n\n\t\t\tCopyright Oficial SysInfo ©");
				Console.ResetColor();
			}
			
		}
		private static void ApresentacaoVinheta(string textoVinheta,int diferenciador)
		{
			Console.WriteLine();
			int posicaoEsq = Console.CursorLeft;
			int tamanho = 20;
			for (int i = 0; i <= tamanho; i++)
			{
				Console.Clear();
				if (diferenciador == 0) home();//<<<< caso não esteja no program 'Alfabeto digital' comente essa linha
				Console.WriteLine("\n\t  {0}", textoVinheta);
				Console.SetCursorPosition(posicaoEsq, Console.CursorTop);
				//BARRA DE CARREGAMENTO
				Console.Write("\n\t |");
				for (int j = 0; j <= i; j++)
				{
					Console.BackgroundColor = ConsoleColor.DarkCyan;
					Console.Write(" ");
				}
				Console.ResetColor();
				//FINAL DA BARRA
				for (int j = i; j <= (tamanho - 1); j++) Console.Write(" ");
				for (int z = 0; z<= tamanho; z++) if (i == z) Console.Write("| "+((100 / tamanho) * z)+" %");
				Thread.Sleep(50);
			}
		}
		static void alfabeto(letra [] lt)
		{
			lt[0].predef2 = 'a';
			lt[1].predef2 = 'b';
			lt[2].predef2 = 'c';
			lt[3].predef2 = 'd';
			lt[4].predef2 = 'e';
			lt[5].predef2 = 'f';
			lt[6].predef2 = 'g';
			lt[7].predef2 = 'h';
			lt[8].predef2 = 'i';
			lt[9].predef2 = 'j';
			lt[10].predef2 = 'k';
			lt[11].predef2 = 'l';
			lt[12].predef2 = 'm';
			lt[13].predef2 = 'n';
			lt[14].predef2 = 'o';
			lt[15].predef2 = 'p';
			lt[16].predef2 = 'q';
			lt[17].predef2 = 'r';
			lt[18].predef2 = 's';
			lt[19].predef2 = 't';
			lt[20].predef2 = 'u';
			lt[21].predef2 = 'v';
			lt[22].predef2 = 'w';
			lt[23].predef2 = 'x';
			lt[24].predef2 = 'y';
			lt[25].predef2 = 'z';
			lt[0].predef = 'A';
			lt[0].linha1 = "_____DSDSDS_____";
			lt[0].linha2 = "___SDSDSDSDSD___";
			lt[0].linha3 = "__SSDSD__DSDSD__";
			lt[0].linha4 = "_SDSDD____SDSDD_";
			lt[0].linha5 = "_SDSDSSDSDSDSDS_";
			lt[0].linha6 = "_DSDSDDSDSSDSDS_";
			lt[0].linha7 = "_DSDSD____SDSDS_";
			lt[0].linha8 = "_DSDSD____SDSDS_";
			lt[1].predef = 'B';
			lt[1].linha1 = "HGHGHGGHGHGHG___";
			lt[1].linha2 = "_GHGHG____GHGH__";
			lt[1].linha3 = "_GHGHG____GHGHG_";
			lt[1].linha4 = "_GHGHGHGHGHGHG__";
			lt[1].linha5 = "_GHGHGHGHGHG____";
			lt[1].linha6 = "_GHGHG____HGHG__";
			lt[1].linha7 = "_GHGHG____GHGHG_";
			lt[1].linha8 = "HGHGHGGHGHGHGH__";
			lt[2].predef = 'C';
			lt[2].linha1 = "___QWQWQWQWQW___";
			lt[2].linha2 = "__QWQWQ___QWQWQ_";
			lt[2].linha3 = "_QWQWQ__________";
			lt[2].linha4 = "_WQWQQ__________";
			lt[2].linha5 = "_QWQWW__________";
			lt[2].linha6 = "_QWQWQ__________";
			lt[2].linha7 = "__QWQWQ___QWQWQ_";
			lt[2].linha8 = "___QWQWQWQWQWQ__";
			lt[3].predef = 'D';
			lt[3].linha1 = "_POPOPPOPOP_____";
			lt[3].linha2 = "_POPOP__POPOP___";
			lt[3].linha3 = "_POPOP___POPOP__";
			lt[3].linha4 = "_POPOP____POPOP_";
			lt[3].linha5 = "_POPOP____POPOP_";
			lt[3].linha6 = "_POPOP___POPOP__";
			lt[3].linha7 = "_POPOP__POPOP___";
			lt[3].linha8 = "_POPOPOPOP______";
			lt[4].predef = 'E';
			lt[4].linha1 = "BVBVBVBVBVBVBV__";
			lt[4].linha2 = "_VBVBV___VBVBVB_";
			lt[4].linha3 = "_VBVBV__________";
			lt[4].linha4 = "_VBVBVBVBVB_____";
			lt[4].linha5 = "_VBVBVBVBVB_____";
			lt[4].linha6 = "_VBVBV__________";
			lt[4].linha7 = "_VBVBV___VBVBVB_";
			lt[4].linha8 = "BVBVBVBVBVBVBV__";
			lt[5].predef = 'F';
			lt[5].linha1 = "_TRTRTRTRTRTRTR__";
			lt[5].linha2 = "__RTRTR___RTRTRT_";
			lt[5].linha3 = "__RTRTR__________";
			lt[5].linha4 = "__RTRTRTRTRT_____";
			lt[5].linha5 = "__RTRTRTRTRT_____";
			lt[5].linha6 = "__RTRTR__________";
			lt[5].linha7 = "__RTRTR__________";
			lt[5].linha8 = "_RTRTRTR_________";
			lt[6].predef = 'G';
			lt[6].linha1 = "____ASASASASAS__";
			lt[6].linha2 = "__ASASA___ASASA_";
			lt[6].linha3 = "_ASASA__________";
			lt[6].linha4 = "_ASASA__________";
			lt[6].linha5 = "_ASASA_SASASASA_";
			lt[6].linha6 = "_ASASA_SA_ASASA_";
			lt[6].linha7 = "__ASASA___SASAS_";
			lt[6].linha8 = "____SASASASASA__";
			lt[7].predef = 'H';
			lt[7].linha1 = "_KOKOKOK__KOKOKOK_";
			lt[7].linha2 = "__OKOKO____OKOKO__";
			lt[7].linha3 = "__OKOKO____OKOKO__";
			lt[7].linha4 = "__OKOKOKOKOOKOKO__";
			lt[7].linha5 = "__OKOKOKOKOOKOKO__";
			lt[7].linha6 = "__OKOKO____OKOKO__";
			lt[7].linha7 = "__OKOKO____OKOKO__";
			lt[7].linha8 = "_KOKOKOK__KOKOKOK_";
			lt[8].predef = 'I';
			lt[8].linha1 = "_CVVCVCV_";
			lt[8].linha2 = "__VVCVC__";
			lt[8].linha3 = "__VVCVC__";
			lt[8].linha4 = "__VVCVC__";
			lt[8].linha5 = "__VVCVC__";
			lt[8].linha6 = "__VCCVC__";
			lt[8].linha7 = "__VCVCV__";
			lt[8].linha8 = "_CVCVVCV_";
			lt[9].predef = 'J';
			lt[9].linha1 = "_ALALALALALALAL_";
			lt[9].linha2 = "_ALALALALALALAL_";
			lt[9].linha3 = "________LALA____";
			lt[9].linha4 = "________LALA____";
			lt[9].linha5 = "________LALA____";
			lt[9].linha6 = "_ALALA__LALA____";
			lt[9].linha7 = "_ALALA__ALAL____";
			lt[9].linha8 = "___ALALALAL_____";
			lt[10].predef = 'K';
			lt[10].linha1 = "_OOUOU___UOUOU__";
			lt[10].linha2 = "_OOUO___UOUO____";
			lt[10].linha3 = "_OOUO__UOUO_____";
			lt[10].linha4 = "_UOUOUOUO_______";
			lt[10].linha5 = "_OOUOUOUOU______";
			lt[10].linha6 = "_OUUO___UOUO____";
			lt[10].linha7 = "_OUOU____UOUO___";
			lt[10].linha8 = "_OUOOU___UOUOUO_";
			lt[11].predef = 'L';
			lt[11].linha1 = "_CXCXCXC_________";
			lt[11].linha2 = "__XCXCX__________";
			lt[11].linha3 = "__XCXCX__________";
			lt[11].linha4 = "__XCXCX__________";
			lt[11].linha5 = "__XCXCX__________";
			lt[11].linha6 = "__XCXCX___XCXCXC_";
			lt[11].linha7 = "__XCXCX____XCXC__";
			lt[11].linha8 = "_CXCXCXCXCXCXCX__";
			lt[12].predef = 'M';
			lt[12].linha1 = "_KJKJKJ____KJKJKJ_";
			lt[12].linha2 = "__JKJKJK__JKJKJK__";
			lt[12].linha3 = "__JKJKJKJKJKJKJK__";
			lt[12].linha4 = "__JKJK_JKJK_JKJK__";
			lt[12].linha5 = "__JKJK__JK__JKJK__";
			lt[12].linha6 = "__JKJK______JKJK__";
			lt[12].linha7 = "__JKJK______JKJK__";
			lt[12].linha8 = "_KJKJKJ____KJKJKJ_";
			lt[13].predef = 'N';
			lt[13].linha1 = "_QPQPQ_____QPQPQ_";
			lt[13].linha2 = "__QPQPQP____QPQP_";
			lt[13].linha3 = "__QPQPQPQ___QPQP_";
			lt[13].linha4 = "__QPQPQPQP__QPQP_";
			lt[13].linha5 = "__QPQP_PQPQ_QPQP_";
			lt[13].linha6 = "__QPQP__PQPQQPQP_";
			lt[13].linha7 = "__QPQP___PQPQPQP_";
			lt[13].linha8 = "_PQPQPQ___QPQPQP_";
			lt[14].predef = 'O';
			lt[14].linha1 = "_____MLMLMLM____";
			lt[14].linha2 = "___MLMLMLMMLML__";
			lt[14].linha3 = "__MLML_____MLML_";
			lt[14].linha4 = "_MLML_______MLML";
			lt[14].linha5 = "_MLML_______MLML";
			lt[14].linha6 = "__MLML_____MLML_";
			lt[14].linha7 = "___LMLMLMLMLML__";
			lt[14].linha8 = "_____LMLMLML____";
			lt[15].predef = 'P';
			lt[15].linha1 = "XZXZXZXZXZX____";
			lt[15].linha2 = "_ZXZXZXZXZXZX__";
			lt[15].linha3 = "_ZXZX____ZXZXZ_";
			lt[15].linha4 = "_ZXZX___ZXZXZ__";
			lt[15].linha5 = "_ZXZXZXZXZXZ___";
			lt[15].linha6 = "_ZXZXZXZXZ_____";
			lt[15].linha7 = "_ZXZX__________";
			lt[15].linha8 = "XZXZXZ_________";
			lt[16].predef = 'Q';
			lt[16].linha1 = "_____MLMLML_____";
			lt[16].linha2 = "___MLMLMLMMLML__";
			lt[16].linha3 = "__MLML_____MLML_";
			lt[16].linha4 = "_MLML_______MLML";
			lt[16].linha5 = "_MLML___ML__MLML";
			lt[16].linha6 = "__MLML___MLMLML_";
			lt[16].linha7 = "___LMLMLMLMLML__";
			lt[16].linha8 = "_____LMLMLM__ML_";
			lt[17].predef = 'R';
			lt[17].linha1 = "_QQWQWQWQWQW____";
			lt[17].linha2 = "__QWQWQWQWQWQW__";
			lt[17].linha3 = "__QWQW____QWQWQ_";
			lt[17].linha4 = "__QWQW___QWQWQ__";
			lt[17].linha5 = "__QWQWQWQWQWQ___";
			lt[17].linha6 = "__QWQWQWQWQQ____";
			lt[17].linha7 = "__QWQW___QWQWQ__";
			lt[17].linha8 = "_WQWQW____QWQWQW";
			lt[18].predef = 'S';
			lt[18].linha1 = "___ERERERERE__";
			lt[18].linha2 = "__ERER___ERER_";
			lt[18].linha3 = "_ERERE________";
			lt[18].linha4 = "__ERERERERE___";
			lt[18].linha5 = "___ERERERERE__";
			lt[18].linha6 = "________ERERE_";
			lt[18].linha7 = "_ERER___ERERE_";
			lt[18].linha8 = "__EREERERERE__";
			lt[19].predef = 'T';
			lt[19].linha1 = "_DFDFDFDFDDFFD_";
			lt[19].linha2 = "_DFDFDFDFDDFFD_";
			lt[19].linha3 = "_____DFFDF_____";
			lt[19].linha4 = "_____DFFDF_____";
			lt[19].linha5 = "_____DFFDF_____";
			lt[19].linha6 = "_____DFFDF_____";
			lt[19].linha7 = "_____DFFDF_____";
			lt[19].linha8 = "____FDFFDFD____";
			lt[20].predef = 'U';
			lt[20].linha1 = "_KLKL______LKLK_";
			lt[20].linha2 = "_KLKL______LKLK_";
			lt[20].linha3 = "_KLKL______LKLK_";
			lt[20].linha4 = "_KLKL______LKLK_";
			lt[20].linha5 = "_KLKL______LKLK_";
			lt[20].linha6 = "_KLKLK____KLKLK_";
			lt[20].linha7 = "__KKLKLKKLKLKL__";
			lt[20].linha8 = "____LKKKLKLK____";
			lt[21].predef = 'V';
			lt[21].linha1 = "_AHAH_______AHAH_";
			lt[21].linha2 = "_AHAH_______AHAH_";
			lt[21].linha3 = "_AHAH_______AHAH_";
			lt[21].linha4 = "_AHAH_______AHAH_";
			lt[21].linha5 = "__AHAH_____AHAH__";
			lt[21].linha6 = "___AHAH___AHAH___";
			lt[21].linha7 = "____AHAH_AHAH____";
			lt[21].linha8 = "_____AHAHAHA_____";
			lt[22].predef = 'W';
			lt[22].linha1 = "_ZXZX_________ZXZX_";
			lt[22].linha2 = "_ZXZX___XZX___ZZXZ_";
			lt[22].linha3 = "_ZXZX___XZX___ZZXZ_";
			lt[22].linha4 = "_XXZX___XZX___XZXZ_";
			lt[22].linha5 = "_ZXZX___XZX___XZXZ_";
			lt[22].linha6 = "_XXZX___XZX___XZXZ_";
			lt[22].linha7 = "_XXZX__ZXZZX__ZXZX_";
			lt[22].linha8 = "__XZXZXZ__XZXXZX___";
			lt[23].predef = 'X';
			lt[23].linha1 = "LOLO_______LOLO";
			lt[23].linha2 = "_LOLO_____LOLO_";
			lt[23].linha3 = "__LOLOL_OLOLO__";
			lt[23].linha4 = "___OLOLOLOLO___";
			lt[23].linha5 = "___OLOLLOLOL___";
			lt[23].linha6 = "__LOLOL_OLOLO__";
			lt[23].linha7 = "_LOLOL___OLOLO_";
			lt[23].linha8 = "LOLOL_____OLOLO";
			lt[24].predef = 'Y';
			lt[24].linha1 = "_GHGH_______GHGH_";
			lt[24].linha2 = "__GHGH_____GHGH__";
			lt[24].linha3 = "___GHGH___GHGH___";
			lt[24].linha4 = "____GHGH_GHGH____";
			lt[24].linha5 = "_____GHGHGHG_____";
			lt[24].linha6 = "______HGHGH______";
			lt[24].linha7 = "______HGHGH______";
			lt[24].linha8 = "______HGHGH______";
			lt[25].predef = 'Z';
			lt[25].linha1 = "_CVCVCVCVCVCVCV_";
			lt[25].linha2 = "_CVCVCVCVCVCVCV_";
			lt[25].linha3 = "_________CVCVC__";
			lt[25].linha4 = "__CVCVCCVCVCCVC_";
			lt[25].linha5 = "_____CVCVC______";
			lt[25].linha6 = "___CVCVC________";
			lt[25].linha7 = "_CVCVCVCVCVCVCV_";
			lt[25].linha8 = "_CVCVCVCVCVCVCV_";
			lt[26].predef = ' ';
			lt[26].linha1 = "________________";
			lt[26].linha2 = "________________";
			lt[26].linha3 = "________________";
			lt[26].linha4 = "________________";
			lt[26].linha5 = "________________";
			lt[26].linha6 = "________________";
			lt[26].linha7 = "________________";
			lt[26].linha8 = "________________";
		}
	}
}
