using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace disconnectedModeActivite3bis
{
    public partial class Form1 : Form
    {
        //Represente une base locale
        private DataSet MonData = new DataSet("MonData");
        private bool load = false;

        //La chaine de connexion
        private string connString = 
         @"Data Source=.\SQLEXPRESS;Initial Catalog=passionsDB;Integrated Security=true";
        //On va avoir besoin de la connexion
        private SqlConnection con;
        //Le pont = Créer partiellemnt le schema et le Data
        //à partir d'une base de données distante
        private SqlDataAdapter adapterPersonnes;
        private SqlDataAdapter adapterPassions;
        private SqlDataAdapter adapterPersPass;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connString);
            //Creer un objet Commande
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Personnes";
            //le cmd represente le select
            adapterPersonnes = new SqlDataAdapter(cmd);

            cmd = new SqlCommand("SELECT * FROM Passions",con);
            adapterPassions = new SqlDataAdapter(cmd);

            cmd = new SqlCommand("SELECT * FROM PersPass", con);
            adapterPersPass = new SqlDataAdapter(cmd);

            //Remplir le DataSet
            //l'adapter ramene seulement la structure et le data (pas de contrainte)
            adapterPersonnes.Fill(MonData, "Personnes");
            adapterPassions.Fill(MonData, "Passions");
            adapterPersPass.Fill(MonData, "PersPass");

            //Les liaisons 
            grdPers.DataSource = MonData;
            grdPers.DataMember = "Personnes";

            grdPass.DataSource = MonData;
            grdPass.DataMember = "Passions";

            grdPersPass.DataSource = MonData;
            grdPersPass.DataMember = "PersPass";


            MonData.Tables["Personnes"].PrimaryKey = new DataColumn[] {
               MonData.Tables["Personnes"].Columns["IndexNom"]
           };

            MonData.Tables["Passions"].PrimaryKey = new DataColumn[] {
               MonData.Tables["Passions"].Columns["IndexPass"]
           };
            MonData.Tables["PersPass"].PrimaryKey = new DataColumn[] {
               MonData.Tables["PersPass"].Columns["IndexNom"],
                 MonData.Tables["PersPass"].Columns["IndexPass"]
           };

            //Declaration des relations 

            DataRelation rel =
                new DataRelation(
                    "PersInt",
                    MonData.Tables["Personnes"].Columns["IndexNom"],
                    MonData.Tables["PersPass"].Columns["IndexNom"]
                );

            MonData.Relations.Add(rel);

            rel =
                new DataRelation(
                    "PassInt",
                    MonData.Tables["Passions"].Columns["IndexPass"],
                    MonData.Tables["PersPass"].Columns["IndexPass"]
                );

            MonData.Relations.Add(rel);

            load = true;

        }

        private void grdPers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void grdPass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void grdPers_CurrentCellChanged(object sender, EventArgs e)
        {
            if (load)
            {
                DataRow rowPers =
                     MonData.Tables["Personnes"].Rows[grdPers.CurrentCell.RowIndex];
                string msg = " Le nom : " + rowPers["Nom"] + "\n";
                DataRow[] lignesfille = rowPers.GetChildRows("PersInt");

                foreach (DataRow row in lignesfille)
                {
                    DataRow parentRow = row.GetParentRow("PassInt");
                    msg += parentRow["Passion"] + "\n";
                }
                MessageBox.Show(msg);
            }
        }

        private void grdPass_CurrentCellChanged(object sender, EventArgs e)
        {
            if (load)
            {
                DataRow rowPassion =
                     MonData.Tables["Passions"].Rows[grdPers.CurrentCell.RowIndex];
                string msg = " Le nom : " + rowPassion["Passion"] + "\n";
                DataRow[] lignesfille = rowPassion.GetChildRows("PassInt");

                foreach (DataRow row in lignesfille)
                {
                    DataRow parentRow = row.GetParentRow("PersInt");
                    msg += parentRow["Nom"] + "\n";
                }
                MessageBox.Show(msg);
            }
        }
    }
}
