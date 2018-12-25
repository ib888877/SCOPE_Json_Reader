using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ScopeCards.DB;
using ScopeCards.Code;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
//using JsonDB;

namespace ScopeCards
{
    public partial class CardForm : Form
    {
        public CardForm()
        {
            InitializeComponent();
        }

        private void upload_Click(object sender, EventArgs e)
        {
            string path10 = "Json";
            var fullPath1 = Path.GetFullPath(path10);

            try
            {
                Directory.CreateDirectory(fullPath1);
            }
            catch (Exception ex)
            {
                // handle them here
            }

            string path1 = "Json\\Data.json";
            var fullPath = Path.GetFullPath(path1);

            OpenFileDialog op1 = new OpenFileDialog();

            op1.Multiselect = false;

            op1.ShowDialog();

            op1.Filter = "allfiles|*.json";

            //textBox1.Text = op1.FileName;

            int count = 0;

            string[] FName;

            foreach (string s in op1.FileNames)

            {

                FName = s.Split('\\');



                //String path = HttpContext.Current.Server.MapPath("/");
                //string path = Path.Combine(Current.Server.MapPath("~/Json"), "Data.json");
                if (File.Exists(fullPath))
                {
                    File.Delete(fullPath);
                }
                File.Copy(s, fullPath);

                count++;

            }

            //MessageBox.Show(Convert.ToString(count) + " File(s) copied");
            MessageBox.Show("File copied");

            string wJson = File.ReadAllText(fullPath);
            MIB.cardtbl = JsonConvert.DeserializeObject<List<Card>>(wJson);
            GVCards.DataSource = MIB.cardtbl;
        }

        //private void GVCards_SelectionChanged(object sender, DataGridViewCellEventArgs e)

        private void GVCards_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (GVCards == null)
                    return;

                int card_serial_number = Int32.Parse(GVCards.Rows[GVCards.CurrentCell.RowIndex].Cells[0].Value.ToString());
                Card crd = new Card();
                crd = MIB.cardtbl.FirstOrDefault(x => x.card_serial_number == card_serial_number);

                List<int> list = crd.interventions;

                IList<interventions> interV = new List<interventions>();
                foreach (int i in list)
                {
                    interventions interVen = new interventions();
                    interVen.No = i;
                    interV.Add(interVen);
                }

                gvInterventions.DataSource = interV;

                IList<Card.Recipient> rec = new List<Card.Recipient>();
                rec.Add(crd.recipient);
                gvRecipient.DataSource = rec;

                gvAlternates.DataSource = crd.alternates;
            }
            catch { }

        }

        //private void Export_Click(object sender, EventArgs e)
        //{
        //    string com = JsonConvert.SerializeObject(MIB.cardtblExport);
        //    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        //    saveFileDialog1.Filter = "allfiles|*.json";
        //    saveFileDialog1.Title = "Save Json File";
        //    saveFileDialog1.ShowDialog();

        //    File.WriteAllText(saveFileDialog1.FileName, com);
        //}

        private void btnDelete_Click(object sender, EventArgs e)
        {

            Int32 selectedRowCount = GVCards.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                    //try
                    //{
                    int card_serial_number = Int32.Parse(GVCards.Rows[GVCards.SelectedCells[i].RowIndex].Cells[0].Value.ToString());
                    Card crd = new Card();
                    crd = MIB.cardtbl.FirstOrDefault(x => x.card_serial_number == card_serial_number);
                    //MIB.cardtblExport.Add(crd);
                    MIB.cardtbl.Remove(crd);
                    //}
                    //catch { }
                }
                GVCards.ClearSelection();
                GVCards.DataSource = null;
                GVCards.Rows.Clear();

                GVCards.DataSource = MIB.cardtbl;
                GVCards.Refresh();

            }

        }

        private void GVCards_DoubleClick(object sender, EventArgs e)
        {
            string path = "C:\\Cards";

            try
            {
                Directory.CreateDirectory(path);
            }
            catch (Exception ex)
            {
                // handle them here
            }

            Int32 selectedRowCount = GVCards.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                    //try
                    //{
                    int card_serial_number = Int32.Parse(GVCards.Rows[GVCards.SelectedCells[i].RowIndex].Cells[0].Value.ToString());
                    Card crd = new Card();
                    crd = MIB.cardtbl.First(x => x.card_serial_number == card_serial_number);
                    MIB.cardtbl.Remove(crd);

                    string com = JsonConvert.SerializeObject(crd);

                    File.WriteAllText(path + "\\" + crd.card_number + ".json", com);
                    //}
                    //catch { }
                }
                GVCards.ClearSelection();
                GVCards.DataSource = null;
                GVCards.Rows.Clear();

                GVCards.DataSource = MIB.cardtbl;
                GVCards.Refresh();
            }
        }
    }
}
