using MaxMind.Db;
using Microsoft.Build.Framework.XamlTypes;
using System;
using System.Data;
using System.ServiceModel;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using OfficeOpenXml;
using System.IO;
using System.Collections.Generic;
using OfficeOpenXml.Drawing;

namespace VP_10_Base_Project
{
   
    public partial class Form1 : Form
    {
        localhost.WebService wb = new localhost.WebService();

        private ImageList imageLst;
        private System.Drawing.Image selectedImage;
        private string selectedLink;
        private DataTable dt2;
        private DataTable dt_images;
        int rowToDelete = 0;
        bool shouldDelete = false;
        Methods method = new Methods();

        public Form1()
        {
            InitializeComponent();
            imageLst = new ImageList();
            dt2 = new DataTable();
            dt2.Columns.Add("liczba", typeof(int)); 
            dt2.Columns.Add("Id", typeof(int));
            dt2.Columns.Add("kategoria", typeof(string));
            dt2.Columns.Add("nazwa", typeof(string));
            dt2.Columns.Add("cena", typeof(float));
            dt2.Columns.Add("ilość", typeof(string));
            dt2.Columns.Add("zdjecie", typeof(System.Drawing.Image));
            dt2.Columns.Add("link", typeof(string));
            dt_images = new DataTable();
            dt_images.Columns.Add("Id", typeof(int));
            dt_images.Columns.Add("kategoria", typeof(string));
            dt_images.Columns.Add("nazwa", typeof(string));
            dt_images.Columns.Add("cena", typeof(float));
            dt_images.Columns.Add("ilość", typeof(string));
            dt_images.Columns.Add("zdjecie", typeof(System.Drawing.Image));
            dt_images.Columns.Add("link", typeof(string));
            button_dodaj.Enabled = false;
        }

        #region UI Event Handlers

        private void cmdGO_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt = wb.showClient();
            wyniki.DataSource = dt;
            // wyniki.ColumnAdded()
            wyniki.RowHeadersVisible = false;
            // wyniki.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            wyniki.DataSource = string.Empty;
        }

        private void cmdCopy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(wyniki.Text);
        }

        #endregion

        //private void Button1_Click(object sender, EventArgs e)
        //{
        //    ServiceReference1.WebServiceSoapClient web = new ServiceReference1.WebServiceSoapClient();
        //    DataTable dt = web.searchClient(imie: kategoria.Text, nazwisko: nazwa.Text);
        //    wyniki.DataSource = dt;
        //    wyniki.RowHeadersVisible = false;
        //    int n = dt.Rows.Count;
        //    liczba.Text = ("znaleziono "+n + " klientow!");

        //    //if(imie.Text == string.Empty || nazwisko.Text == string.Empty)
        //    //{
        //        //MessageBox.Show("Nie podano danych do szukania");
        //        //wyniki.DataSource = null;
        //    //}  
        //    if (wyniki.Rows.Count > 1 && wyniki.Rows != null)
        //    {
        //        dodaj.Enabled = false;
        //    }
        //    else
        //    {
        //        dodaj.Enabled = true;
        //        id.Enabled = false;
        //        eximie.Text = kategoria.Text;
        //        exnazwisko.Text = nazwa.Text;

        //    }
            
           


        //}


      /*  private void Button2_Click(object sender, EventArgs e)
        {
  
            ServiceReference1.WebServiceSoapClient web = new ServiceReference1.WebServiceSoapClient();
            web.newClient(imie: kategoria.Text, nazwisko: nazwa.Text, opis: exopis.Text);
            wyniki.RowHeadersVisible = false;
            //MessageBox.Show("dodano!");

        }*/


      

        private void Usun_Click(object sender, EventArgs e)
        {
            if(shouldDelete)
            {
                dt2.Rows.RemoveAt(rowToDelete);
                shouldDelete = false;
                wynikiPrawe.DataSource = dt2;
                float kwota = 0.0f;
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    float cena = float.Parse(dt2.Rows[i][4].ToString());
                    int ilosc = int.Parse(dt2.Rows[i][0].ToString());
                    kwota += (cena * ilosc);
                }
                text_kwota.Text = kwota.ToString();
                button_usun.Enabled = false;
            }
            //ServiceReference1.WebServiceSoapClient web = new ServiceReference1.WebServiceSoapClient();
            //web.deleteClient(id: int.Parse(text_id.Text), imie: text_kategoria.Text, nazwisko: text_opis.Text);
            //wyniki.RowHeadersVisible = false;
            //MessageBox.Show("usunieto");
            //button_usun.Enabled = false;

        }

        private void Id_TextChanged(object sender, EventArgs e)
        {
            text_id.Enabled = false;
        }

        private void Wyniki_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = wyniki.Rows[e.RowIndex];
                text_id.Text = row.Cells[0].Value.ToString();
                text_kategoria.Text = row.Cells[1].Value.ToString();
                text_opis.Text = row.Cells[2].Value.ToString();
                text_cena.Text = row.Cells[3].Value.ToString();
                typTextBox.Text = row.Cells[4].Value.ToString();
                selectedImage = (System.Drawing.Image)row.Cells[5].Value;
                selectedLink = row.Cells[6].Value.ToString();
                button_dodaj.Enabled = true;
            }
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
          
            DataTable dt = method.szukajKategorie();
            listaKategorii.DataSource = dt;
            listaKategorii.DisplayMember = "kategoria";
          

            int n = dt.Rows.Count;           
        }

        

        private void Dodaj_Click(object sender, EventArgs e)
        {
            /*
            DataRow r = dt2.NewRow();
            float kwota = 0.0f;
            //r.SetField(0, int.Parse(text_ilosc.Text));
            r[0] = numberic_ilosc.Value;
            //r.SetField(1, int.Parse(text_id.Text));
            r[1] = int.Parse(text_id.Text);
            //r.SetField(2, text_kategoria.Text);
            r[2] = text_kategoria.Text;
            //r.SetField(3, text_opis.Text);
            r[3] = text_opis.Text;
            //r.SetField(4, float.Parse(text_cena.Text));
            r[4] = float.Parse(text_cena.Text);
            r[5] = typTextBox.Text;
            r[6] = selectedImage;
            dt2.Rows.Add(r);
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                float cena = float.Parse(dt2.Rows[i][4].ToString());
                int ilość = int.Parse(dt2.Rows[i][0].ToString());
                kwota += (cena * ilość);
            }
            text_kwota.Text = kwota.ToString();
            wynikiPrawe.DataSource = dt2;
            */
        }

        private void Button3_Click(object sender, EventArgs e)
        {
           
            
            string kat_val = listaKategorii.GetItemText(listaKategorii.SelectedItem);
            DataTable dt1 = method.szukajPrzedmiot(kategoria: kat_val);
            dt_images.Clear();
            foreach(DataRow nr in dt1.Rows)
            {
                DataRow r = dt_images.NewRow();
                r[0] = nr[0];
                r[1] = nr[1];
                r[2] = nr[2];
                r[3] = nr[3];
                r[4] = nr[4];
                r[5] = System.Drawing.Image.FromFile("images/" + (string)nr[5]);
                r[6] = nr[6];
                dt_images.Rows.Add(r);
            }
            wyniki.DataSource = dt_images;
            wyniki.Columns[0].MinimumWidth = 20;
            wyniki.Columns[1].MinimumWidth = 100;
            wyniki.Columns[2].MinimumWidth = 100;
            wyniki.Columns[3].MinimumWidth = 20;
            wyniki.Columns[4].MinimumWidth = 20;
            wyniki.Columns[5].Width = 200;
            ((DataGridViewImageColumn)wyniki.Columns[5]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            wyniki.Columns[6].Width = 100;
            //wyniki.Columns["id"].Visible = false;
        }

        private void WynikiPrawe_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {       
            if (e.RowIndex >= 0)
            {
                rowToDelete = e.RowIndex;
                shouldDelete = true;
                button_usun.Enabled = true;
            }

        }
        private void button_generujpdf_Click(object sender, EventArgs e)
        {
            List<string> categoriesList = new List<string>();
            List<Estimate>[] dataList = new List<Estimate>[100];
            foreach(DataRow row in dt2.Rows)
            {
                bool added = false;
                for(int i = 0; i < categoriesList.Count; i++)
                {
                    if ((string)row[2] == categoriesList[i])
                    {
                        added = true;
                        dataList[i].Add(new Estimate((int)row[0],(string)row[2], (string)row[3], (float)row[4], (string)row[5], (System.Drawing.Image)row[6], (string)row[7]));
                    }
                }
                if (!added)
                {
                    int n = categoriesList.Count;
                    categoriesList.Add((string)row[2]);
                    dataList[n] = new List<Estimate>();
                    dataList[n].Add(new Estimate((int)row[0], (string)row[2], (string)row[3], (float)row[4], (string)row[5], (System.Drawing.Image)row[6], (string)row[7]));
                }
            }
            using (var p = new ExcelPackage())
            {
                int i = 0;
                int startRow = 2;
                ExcelWorksheet ws = p.Workbook.Worksheets.Add("Kosztorys");
                ws.Cells.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                ws.Cells.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                ws.Cells.Style.WrapText = true;
                ws.Cells[1, 1, 1, 9].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                ws.Cells[1, 1, 1, 9].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGreen);
                ws.Cells[1, 1].Value = "Lp.";
                ws.Cells[1, 2].Value = "Zdjęcie";
                ws.Cells[1, 3].Value = "Nazwa";
                ws.Cells[1, 4].Value = "Ilość";
                ws.Cells[1, 5].Value = "Jednostka";
                ws.Cells[1, 6].Value = "Cena Jednostkowa";
                ws.Cells[1, 7].Value = "Cena Netto";
                ws.Cells[1, 8].Value = "Cena Brutto";
                ws.Cells[1, 9].Value = "Link";
                ws.Cells[1, 10].Value = "Uwagi";
                ws.Row(1).Height = 40;
                for (int j = 0; j < categoriesList.Count; j++)
                {
                    ws.Cells[startRow, 1, startRow, 9].Merge = true;
                    ws.Cells[startRow, 1, startRow, 9].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    ws.Cells[startRow, 1, startRow, 9].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGreen);
                    ws.Cells[startRow, 1, startRow, 9].Value = categoriesList[j];
                    startRow++;
                    for (int n = 0; n < dataList[j].Count; n++)
                    {
                        ws.Column(2).Width = 20;
                        ws.Column(3).Width = 20;
                        ws.Column(9).Width = 20;
                        ws.Column(10).Width = 40;
                        ws.Row(startRow).Height = 140;
                        Estimate data = dataList[j][n];
                        ExcelPicture picture = ws.Drawings.AddPicture(data.description+i.ToString(),data.image);
                        picture.From.Column = 1;
                        picture.From.Row = startRow-1;
                        picture.To.Column = 1;//end cell value
                        picture.To.Row = startRow-1;//end cell value
                        picture.SetSize(138, 150);
                        
                        ws.Cells[startRow, 1].Value = i;
                        ws.Cells[startRow, 3].Value = data.description;
                        ws.Cells[startRow, 4].Value = data.amount;
                        ws.Cells[startRow, 5].Value = data.format;
                        ws.Cells[startRow, 6].Value = (float)data.price;
                        ws.Cells[startRow, 7].Value = (data.price*data.amount);
                        ws.Cells[startRow, 8].Value = (data.price * data.amount + 0.23 * data.price * data.amount);
                        ws.Cells[startRow, 9].Value = data.link;
                        ws.Cells[startRow, 8].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        ws.Cells[startRow, 8].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGreen);
                        ws.Cells[startRow, 9].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        ws.Cells[startRow, 9].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGreen);
                        startRow++;
                        i++;
                    }
                }
                ws.Row(startRow).Height = 40;
                ws.Cells[startRow, 1, startRow, 5].Merge = true;
                ws.Cells[startRow, 6, startRow, 7].Merge = true;
                ws.Cells[startRow, 6].Value = "Koszt całkowity:";
                ws.Cells[startRow, 1, startRow, 9].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                ws.Cells[startRow, 1, startRow, 9].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGreen);
                ws.Cells[startRow, 8].Formula = "=SUM(" + ws.Cells[2, 8].Address + ":" + ws.Cells[startRow - 1, 8].Address + ")";
                ws.Cells[startRow, 9].Value = "ZŁ";
                // Displays a SaveFileDialog so the user can save the Image
                // assigned to Button2.
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Excel file|*.xlsx";
                saveFileDialog1.Title = "Save an Excel File";
                saveFileDialog1.ShowDialog();

                // If the file name is not an empty string open it for saving.
                if (saveFileDialog1.FileName != "")
                {
                    byte[] data = p.GetAsByteArray();
                    // Saves the Image via a FileStream created by the OpenFile method.
                    System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                    fs.Seek(0,SeekOrigin.Begin);
                    fs.Write(data,0,data.Length);
                    fs.Close();
                }
            }
        }
        private void button_dodaj_Click(object sender, EventArgs e)
        {
            DataRow r = dt2.NewRow();
            float kwota = 0.0f;
            //r.SetField(0, int.Parse(text_ilosc.Text));
            r[0] = numberic_ilosc.Value;
            //r.SetField(1, int.Parse(text_id.Text));
            r[1] = int.Parse(text_id.Text);
            //r.SetField(2, text_kategoria.Text);
            r[2] = text_kategoria.Text;
            //r.SetField(3, text_opis.Text);
            r[3] = text_opis.Text;
            //r.SetField(4, float.Parse(text_cena.Text));
            r[4] = float.Parse(text_cena.Text);
            r[5] = typTextBox.Text;
            r[6] = selectedImage;
            r[7] = selectedLink;
            dt2.Rows.Add(r);
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                float cena = float.Parse(dt2.Rows[i][4].ToString());
                int ilość = int.Parse(dt2.Rows[i][0].ToString());
                kwota += (cena * ilość);
            }
            text_kwota.Text = kwota.ToString();
            wynikiPrawe.DataSource = dt2;
            wynikiPrawe.Columns[0].MinimumWidth = 20;
            wynikiPrawe.Columns[1].MinimumWidth = 20;
            wynikiPrawe.Columns[2].MinimumWidth = 100;
            wynikiPrawe.Columns[3].MinimumWidth = 100;
            wynikiPrawe.Columns[4].MinimumWidth = 20;
            wynikiPrawe.Columns[5].MinimumWidth = 20;
            ((DataGridViewImageColumn)wynikiPrawe.Columns[6]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            wynikiPrawe.Columns[6].Width = 200;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void wyniki_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Text_opis_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListaKategorii_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_pokazprzedmioty.Enabled = true;
        }
    }
}
