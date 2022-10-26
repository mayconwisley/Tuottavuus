using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Controle
{
    public class Utilitarios
    {
        public string CaminhoArquivo()
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Selecione um arquivo";
            openFileDialog.Filter = "Arquivo CSV (*.csv)|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            else
            {
                return null;
            }
        }
        public ArrayList LerArquivo(string caminhoArquivo)
        {
            ArrayList linhaArquivo = new ArrayList();
            try
            {
                using (var arquivo = new StreamReader(caminhoArquivo))
                {
                    string linha = string.Empty;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        linhaArquivo.Add(linha);
                    }
                }
                return linhaArquivo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void SalvarArquivo(string dados)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "Arquivo CSV (*.csv)|*.csv",
                Title = "Salvar arquivo CSV",
                FilterIndex = 1,
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, dados, Encoding.UTF8);
            }
        }
    }
}
