using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Healing.Tools
{
    public static class PrepararDadosPBanco
    {
        public static void Preparar(System.Type type, ref object Obj)
        {
            try
            {
                PropertyInfo[] propriedades = type.GetProperties();

                foreach (PropertyInfo propriedade in propriedades)
                {
                    string valor = "";
                    //try
                    //{
                    //    valor = propriedade.GetValue(Obj, null).ToString().Trim().Replace("'", "").Replace("\\", "").Replace("\"", "");
                    //}
                    //catch (Exception)
                    //{
                    //    continue;
                    //}

                    //propriedade.Name;// pra pegar o nome da propriedade

                    string tipo = propriedade.PropertyType.Name.ToLower();

                    switch (tipo)
                    {
                        case "string":
                            try
                            {
                                valor = propriedade.GetValue(Obj, null).ToString().Replace("'", "").Replace("\\", "").Replace("\"", "").Replace("&", "").Trim();
                                bool removerAcentos = true;

                                if (propriedade.Name.ToLower().IndexOf("observacoes") >= 0 ||
                                    propriedade.Name.ToLower().IndexOf("observacao") >= 0 ||
                                    propriedade.Name.ToLower().IndexOf("mensagem") >= 0 ||
                                    propriedade.Name.ToLower().IndexOf("resolucao") >= 0 ||
                                    propriedade.Name.ToLower().IndexOf("textoprodutosite") >= 0 ||
                                    propriedade.Name.ToLower().IndexOf("contratotexto") >= 0 ||
                                    type.ToString() == "smp.Dominio.CrmContatoAtividade" ||
                                    type.FullName.ToString() == "smp.Dominio.HelpDesk" || type.FullName.ToString() == "smp.Dominio.CrmCampanhaMensagens")
                                {
                                    removerAcentos = false;
                                }

                                if (removerAcentos)
                                {
                                    valor = RetirarAcentos(valor);
                                }

                                if (type.Name == "Orcamento" ||
                                    type.Name == "OrcamentoItem")
                                {
                                    propriedade.SetValue(Obj, valor, null);
                                    continue;
                                }

                                if (propriedade.Name == "EmailSenha" ||
                                    propriedade.Name == "LaudoTecDefeitoEncontrado" ||
                                    propriedade.Name == "LaudoTecResolucao")
                                {

                                }
                                else
                                {
                                    if (propriedade.Name.ToLower().IndexOf("contrato") >= 0)
                                    {

                                    }

                                    bool email = false;

                                    if (propriedade.Name.ToLower().IndexOf("email") >= 0 || propriedade.Name.ToLower().IndexOf("RedeSocial") >= 0)
                                    {
                                        email = true;
                                        if (propriedade.Name == "EmailCorpoMensagem")
                                        {
                                            email = false;
                                        }
                                    }

                                    if (!email)
                                    {
                                        bool removerSimbolos = true;
                                        if (propriedade.Name.ToLower().IndexOf("telefone") >= 0 ||
                                            propriedade.Name.ToLower().IndexOf("observacao") >= 0 ||
                                            propriedade.Name.ToLower().IndexOf("observacoes") >= 0 ||
                                            propriedade.Name.ToLower().IndexOf("valor") >= 0 ||
                                            propriedade.Name.ToLower().IndexOf("detalhes") >= 0 ||
                                            propriedade.Name.ToLower().IndexOf("arquivo") >= 0 ||
                                            propriedade.Name.ToLower().IndexOf("atualizadoporarquivo") >= 0 ||
                                            propriedade.Name.ToLower().IndexOf("comandosretornadosbanco") >= 0 ||
                                            propriedade.Name.ToLower().IndexOf("textoprodutosite") >= 0 ||
                                            propriedade.Name.ToLower().IndexOf("correcao") >= 0 ||
                                            propriedade.Name.ToLower().IndexOf("log") >= 0 ||
                                            propriedade.Name.ToLower().IndexOf("codigoean") >= 0 ||
                                            propriedade.Name.ToLower().IndexOf("formapagamento") >= 0 ||
                                            propriedade.Name.ToLower().IndexOf("mensagem") >= 0 ||
                                            propriedade.Name.ToLower().IndexOf("resolucao") >= 0 ||
                                            propriedade.Name.ToLower().IndexOf("contrato") >= 0 ||
                                            propriedade.Name.ToLower().IndexOf("mensagem") >= 0 ||
                                            type.ToString() == "smp.Dominio.CrmContatoAtividade" ||
                                            type.ToString() == "smp.Dominio.HelpDesk100" ||
                                            propriedade.Name.ToLower().IndexOf("redesocial") >= 0 ||
                                            propriedade.Name.ToLower().IndexOf("defeitorelatado") >= 0 ||
                                            type.FullName.ToString() == "smp.Dominio.HelpDesk" ||
                                            propriedade.Name.ToLower().IndexOf("tokenapi") >= 0 ||
                                            propriedade.Name.ToLower() == "nfsediscriminacaoservico" || type.FullName.ToString() == "smp.Dominio.CrmCampanhaMensagens")

                                        {
                                            removerSimbolos = false;
                                        }
                                        if (removerSimbolos)
                                        {
                                            if (propriedade.Name.ToLower().IndexOf("informacoesadcontribuinte") >= 0)
                                            {
                                                valor = RemoverSimbolos(valor, "$+%");
                                            }
                                            else
                                            {
                                                valor = RemoverSimbolos(valor);
                                            }
                                        }
                                        else
                                        {
                                            valor = valor.Replace("'", "");
                                        }

                                        if (type.Name == "PreNFeItem" &&
                                            propriedade.Name.ToLower().IndexOf("observacao") >= 0)
                                        {
                                            valor = RemoverSimbolos(valor);
                                        }

                                    }
                                    else
                                    {
                                        valor = RemoverSimbolos(valor, "@;");
                                    }
                                }

                                propriedade.SetValue(Obj, valor, null);


                            }
                            catch (Exception ex)
                            {
                            }
                            break;
                    }

                }
            }
            catch (Exception ex)
            {
            }
        }

        private static string RetirarAcentos(string texto)
        {
            string s = texto.Normalize(NormalizationForm.FormD);

            StringBuilder sb = new StringBuilder();

            for (int k = 0; k < s.Length; k++)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(s[k]);
                if (uc != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(s[k]);
                }
            }
            return sb.ToString();
        }

        private static string RemoverSimbolos(string texto, string permitir = "")
        {
            texto = Regex.Replace(texto, "[^0-9a-zA-Z.,_/ ()|#:;" + permitir + "-]+?", ""); // dia 25/03/2020 adicionado :;

            texto = texto.Replace("\r", "").Replace("\n", "").Replace("\t", "").Trim();

            return texto;
        }
    }
}
