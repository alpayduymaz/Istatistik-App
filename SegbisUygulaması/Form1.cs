using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

namespace SegbisUygulaması
{
    public partial class Form1 : Form
    {
        private readonly string cucmHost = "10.201.66.20";
        private readonly string username = "apialpay";
        private readonly string password = "Adalet09";
        BackgroundWorker bgWorker = new BackgroundWorker();

        public Form1()
        {

            this.MinimumSize = new Size(800, 600);
            InitializeComponent();
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, cert, chain, sslPolicyErrors) => true;
            bgWorker.WorkerReportsProgress = true;
            BgWorker_DoWork(null, null);
            //bgWorker.DoWork += BgWorker_DoWork;
            //bgWorker.ProgressChanged += BgWorker_ProgressChanged;
            //bgWorker.RunWorkerCompleted += BgWorker_RunWorkerCompleted;
        }
        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            btnListPhones_Click(null, null);
        }
        private async Task<string> PostSoapRequest(string soapXml)
        {
            string url = $"https://{cucmHost}:8443/axl/";

            var handler = new HttpClientHandler
            {
                Credentials = new NetworkCredential(username, password)
            };

            using (var client = new HttpClient(handler))
            {
                client.Timeout = TimeSpan.FromSeconds(30);

                var content = new StringContent(soapXml, Encoding.UTF8, "text/xml");
                content.Headers.ContentType = new MediaTypeHeaderValue("text/xml");
                content.Headers.Add("SOAPAction", "");

                var response = await client.PostAsync(url, content);

                var res = await response.Content.ReadAsStringAsync();
                LoadPhonesToGrid(res);
                return res;
            }
        }
        private async void btnListPhones_Click(object sender, EventArgs e)
        {
            string soapBody = @"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:axl=""http://www.cisco.com/AXL/API/12.5"">
   <soapenv:Header/>
   <soapenv:Body>
      <axl:listPhone>
         <searchCriteria>
            <name>SEP%</name>
         </searchCriteria>
         <returnedTags>
            <name/>
            <description/>
            <model/>
            <ownerUserName/>
            <protocol/>
         </returnedTags>
      </axl:listPhone>
   </soapenv:Body>
</soapenv:Envelope>";

            string response = await PostSoapRequest(soapBody);
        }
        private async void LoadPhonesToGrid(string xml)
        {
            progressBar1.Value = 0;
            labelLoading.Text = "Yükleniyor...";
            labelLoading.ForeColor = System.Drawing.Color.DarkOrange;
            progressBar1.Visible = true;
            labelLoading.Visible = true;
            var list = new List<PhoneInfo>();

            XDocument doc = XDocument.Parse(xml);

            XNamespace axl = doc.Root.GetDefaultNamespace();

            var phones = doc.Descendants().Where(x => x.Name.LocalName == "phone");

            this.progressBar1.Maximum = phones.Count();

            List<string> uuidList = new List<string>();

            foreach (var p in phones)
            {
                var uuid = p.Attribute("uuid")?.Value;
                uuidList.Add(uuid);
                list.Add(new PhoneInfo
                {
                    Name = p.Elements().FirstOrDefault(x => x.Name.LocalName == "name")?.Value,
                    Description = p.Elements().FirstOrDefault(x => x.Name.LocalName == "description")?.Value,
                    Model = p.Elements().FirstOrDefault(x => x.Name.LocalName == "model")?.Value,
                    OwnerUserName = p.Elements().FirstOrDefault(x => x.Name.LocalName == "ownerUserName")?.Value,
                    Protocol = p.Elements().FirstOrDefault(x => x.Name.LocalName == "protocol")?.Value
                });
                this.progressBar1.Value++;
            }
            
            this.dataGridAllPhones.DataSource = list;

            // MODELLERE GÖRE SAYIM
            int countC60 = list.Count(x => x.Model != null && x.Model.Contains("C60"));
            int countEX90 = list.Count(x => x.Model != null && x.Model.Contains("EX90"));
            int countMX200 = list.Count(x => x.Model != null && x.Model.Contains("MX200"));
            int countSX20 = list.Count(x => x.Model != null && x.Model.Contains("SX20"));
            int countSX80 = list.Count(x => x.Model != null && x.Model.Contains("SX80"));
            int countKitPro = list.Count(x => x.Model != null && x.Model.Contains("Kit Pro"));
            int countKitMini = list.Count(x => x.Model != null && x.Model.Contains("Kit Mini"));
            int countKitEQ = list.Count(x => x.Model != null && x.Model.Contains("Kit EQ"));
            int countRoomBar = list.Count(x => x.Model != null && x.Model.Contains("Room Bar"));

            // LABEL GÜNCELLEME
            this.ciscoC60Label.Text = $"{ciscoC60Label.Text} {countC60}";
            this.ciscoEX90Label.Text = $"{ciscoEX90Label.Text} {countEX90}";
            this.ciscoMX200Label.Text = $"{ciscoMX200Label.Text} {countMX200}";
            this.ciscoSX20Label.Text = $"{ciscoSX20Label.Text} {countSX20}";
            this.ciscoSX80Label.Text = $"{ciscoSX80Label.Text} {countSX80}";
            this.ciscoRoomKitProLabel.Text = $"{ciscoRoomKitProLabel.Text} {countKitPro}";
            this.ciscoRoomKitMiniLabel.Text = $"{ciscoRoomKitMiniLabel.Text} {countKitMini}";
            this.roomKitEQLabel.Text = $"{roomKitEQLabel.Text} {countKitEQ}";
            this.roomBarLabel.Text = $"{roomBarLabel.Text} {countRoomBar}";
            this.toplamLabel1.Text = $"{toplamLabel1.Text} {countC60 + countEX90 + countMX200 + countSX20 + countSX80 + countKitPro + countKitMini + countKitEQ + countRoomBar}";


            // DESC GÖRE SAYIM
            int countCezaMah = list.Count(x => x.Description != null && ((x.Description.Contains("Ceza Mah")) || (x.Description.Contains("ASCM")) || (x.Description.Contains("ACM")) || (x.Description.Contains("SCH"))));
            int countSavcilik = list.Count(x => x.Description != null && x.Description.Contains("Savcilik"));
            int countBAM = list.Count(x => x.Description != null && x.Description.Contains("BAM"));
            int countIdareMah = list.Count(x => x.Description != null && ((x.Description.Contains("BIM")) || (x.Description.Contains("İdare Mah"))));
            int countAGO = list.Count(x => x.Description != null && x.Description.Contains("AGO"));
            int countGT = list.Count(x => x.Description != null && x.Description.Contains("GT"));
            int countYuksekYargi = list.Count(x => x.Description != null && ((x.Description.Contains("Yargitay")) || (x.Description.Contains("Danistay")) || (x.Description.Contains("Anayasa"))));
            int countCezaInfazKurumlari = list.Count(x => x.Description != null && x.Description.Contains(" CIK"));
            int countHSK = list.Count(x => x.Description != null && x.Description.Contains("HSK"));



            // LABEL2 GÜNCELLEME
            this.cezaMahLabel.Text = $"{cezaMahLabel.Text} {countCezaMah}";
            this.savcilikLabel.Text = $"{savcilikLabel.Text} {countSavcilik}";
            this.bamLabel.Text = $"{bamLabel.Text} {countBAM}";
            this.bimLabel.Text = $"{bimLabel.Text} {countIdareMah}";
            this.agoLabel.Text = $"{agoLabel.Text} {countAGO}";
            this.gtLabel.Text = $"{gtLabel.Text} {countGT}";
            this.yuksekYargiLabel.Text = $"{yuksekYargiLabel.Text} {countYuksekYargi}";
            this.hskLabel.Text = $"{hskLabel.Text} {countHSK}";
            this.cikLabel.Text = $"{cikLabel.Text} {countCezaInfazKurumlari}";
            this.toplamLabel2.Text = $"{toplamLabel2.Text} {countCezaMah + countSavcilik + countBAM + countIdareMah + countAGO + countGT + countYuksekYargi + countHSK + countCezaInfazKurumlari}";

            progressBar1.Value = progressBar1.Maximum;
            labelLoading.Text = "Yüklendi ✓";
            labelLoading.ForeColor = System.Drawing.Color.Green;
        }

        private void ExportDataGridViewToExcel(DataGridView dgv, string fileName)
        {
            try
            {
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

                using (SpreadsheetDocument document = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook))
                {
                    WorkbookPart workbookPart = document.AddWorkbookPart();
                    workbookPart.Workbook = new Workbook();

                    WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                    SheetData sheetData = new SheetData();

                    worksheetPart.Worksheet = new Worksheet(sheetData);

                    Sheets sheets = document.WorkbookPart.Workbook.AppendChild(new Sheets());
                    Sheet sheet = new Sheet()
                    {
                        Id = document.WorkbookPart.GetIdOfPart(worksheetPart),
                        SheetId = 1,
                        Name = "Phones"
                    };
                    sheets.Append(sheet);

                    // Header row (Kolon Başlıkları)
                    Row headerRow = new Row();
                    foreach (DataGridViewColumn column in dgv.Columns)
                    {
                        Cell cell = new Cell()
                        {
                            DataType = CellValues.String,
                            CellValue = new CellValue(column.HeaderText)
                        };
                        headerRow.AppendChild(cell);
                    }
                    sheetData.AppendChild(headerRow);

                    // Data rows
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            Row newRow = new Row();
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                newRow.AppendChild(new Cell()
                                {
                                    DataType = CellValues.String,
                                    CellValue = new CellValue(cell.Value?.ToString() ?? "")
                                });
                            }
                            sheetData.AppendChild(newRow);
                        }
                    }
                }

                MessageBox.Show("Excel dosyası başarıyla oluşturuldu:\n" + filePath, "Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void excelExportBtn_Click(object sender, EventArgs e)
        {
            ExportDataGridViewToExcel(dataGridAllPhones, "TelefonListesi.xlsx");
        }
    }
}
