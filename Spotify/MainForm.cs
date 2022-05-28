using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace Spotify
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		MySqlConnection co = new MySqlConnection("Server =localhost; Uid= root; Password=; Database=spotify;");
		
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();	
	
		
		public bool dbOpen()
        {
            try
            {
                koneksi.Open();
                
            }
            catch
            {
				MessageBox.Show(text: "Tidak Terhubung");
                return false;
            }

            return true;
        }
		
		public DataSet ds=new DataSet();
		public MainForm(){
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			}
		
			//Tampilan Data, menampilkan data dari table
			void tampildata(){
			try{
					//MyCommand yang mengambil quey pada mysql
					mycommand.Connection=co;
					myadapter.SelectCommand=mycommand;
					//Quey, dimana ambil semua data di akun
					mycommand.CommandText="select * from laguu";
					DataSet ds = new DataSet();
					
					//Ini pengisian
					if (myadapter.Fill(ds,"dftpesan")>0)
						{
						dataGridView.DataSource = ds;
						dataGridView.DataMember = "dftpesan";
						}
						co.Close();
				}
				catch (Exception ex){
					MessageBox.Show(ex.ToString());
				}
		}	
			
	//MEMASUKKAN INSERT/C
	void TambahClick(object sender, EventArgs e)
			{
				
				try{
				co.Open();
					mycommand.Connection= co;
					//Dimana memasukkan values yg berada pada design yang telah dibuat
					mycommand.CommandText= "insert into laguu values('"+txtjudul+"','"+txtgenre+"', '"+txtkode+"', '"+txtpenyanyi+"', '"+txtalbum+"')";
					myadapter.SelectCommand = mycommand;
				
				if(mycommand.ExecuteNonQuery()==1)
				{
					MessageBox.Show("Data berhasil dimasukkan","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					tampildata();
				}
				co.Close();
				}
				catch (Exception ex){
					MessageBox.Show(ex.ToString());
				}
			}		
		
	
	//MENGUBAH DATA(UPDATE)/U
	void UpdateClick(object sender, EventArgs e)
		{
				try {
					co.Open();
					//mENGAMBIL INSTRUKSI YANG query berikan 
					mycommand.CommandText="update spotify set judul='"+txtjudul+"', genre_lagu ='"+txtgenre+"', kode ='"+txtkode+"',penyanyi='"+txtpenyanyi+"',album='"+txtalbum+"' where kode='"+txtkode+"'";
					myadapter.SelectCommand=mycommand;
					mycommand.ExecuteNonQuery();
					tampildata();
					co.Close();
				}
				catch (Exception ex){
					MessageBox.Show(ex.ToString());
				}
			}
	
	
	//MENGHAPUS DATA(DELETE)/D
		void HapusClick()
		{
		try{
					co.Open();
					mycommand.CommandText="delete from spotify where kode = '"+txtkode+"'";
					myadapter.SelectCommand = mycommand;
					mycommand.ExecuteNonQuery();
					tampildata();
					co.Close();
				}
				catch (Exception ex){
				MessageBox.Show(ex.ToString());
				}
		}
	}
}