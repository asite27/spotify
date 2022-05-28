/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 18/12/2021
 * Time: 20:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Spotify
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Label judul;
		private System.Windows.Forms.Label genre_lagu;
		private System.Windows.Forms.Label kode;
		private System.Windows.Forms.Label penyanyi;
		private System.Windows.Forms.Label album;
		private System.Windows.Forms.Button tambah;
		private System.Windows.Forms.Button hapus;
		private System.Windows.Forms.Button update;
		private System.Windows.Forms.TextBox txtjudul;
		private System.Windows.Forms.TextBox txtgenre;
		private System.Windows.Forms.TextBox txtkode;
		private System.Windows.Forms.TextBox txtpenyanyi;
		private System.Windows.Forms.TextBox txtalbum;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.judul = new System.Windows.Forms.Label();
			this.genre_lagu = new System.Windows.Forms.Label();
			this.kode = new System.Windows.Forms.Label();
			this.penyanyi = new System.Windows.Forms.Label();
			this.album = new System.Windows.Forms.Label();
			this.tambah = new System.Windows.Forms.Button();
			this.hapus = new System.Windows.Forms.Button();
			this.update = new System.Windows.Forms.Button();
			this.txtjudul = new System.Windows.Forms.TextBox();
			this.txtgenre = new System.Windows.Forms.TextBox();
			this.txtkode = new System.Windows.Forms.TextBox();
			this.txtpenyanyi = new System.Windows.Forms.TextBox();
			this.txtalbum = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(12, 12);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(443, 168);
			this.dataGridView.TabIndex = 0;
			// 
			// judul
			// 
			this.judul.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.judul.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.judul.Location = new System.Drawing.Point(41, 209);
			this.judul.Name = "judul";
			this.judul.Size = new System.Drawing.Size(85, 29);
			this.judul.TabIndex = 1;
			this.judul.Text = "Judul";
			// 
			// genre_lagu
			// 
			this.genre_lagu.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.genre_lagu.Location = new System.Drawing.Point(41, 252);
			this.genre_lagu.Name = "genre_lagu";
			this.genre_lagu.Size = new System.Drawing.Size(85, 23);
			this.genre_lagu.TabIndex = 2;
			this.genre_lagu.Text = "Genre";
			// 
			// kode
			// 
			this.kode.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kode.Location = new System.Drawing.Point(35, 297);
			this.kode.Name = "kode";
			this.kode.Size = new System.Drawing.Size(100, 23);
			this.kode.TabIndex = 3;
			this.kode.Text = "Kode";
			// 
			// penyanyi
			// 
			this.penyanyi.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.penyanyi.Location = new System.Drawing.Point(21, 334);
			this.penyanyi.Name = "penyanyi";
			this.penyanyi.Size = new System.Drawing.Size(114, 23);
			this.penyanyi.TabIndex = 4;
			this.penyanyi.Text = "Penyanyi";
			// 
			// album
			// 
			this.album.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.album.Location = new System.Drawing.Point(41, 370);
			this.album.Name = "album";
			this.album.Size = new System.Drawing.Size(100, 23);
			this.album.TabIndex = 5;
			this.album.Text = "Album";
			// 
			// tambah
			// 
			this.tambah.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tambah.Location = new System.Drawing.Point(12, 441);
			this.tambah.Name = "tambah";
			this.tambah.Size = new System.Drawing.Size(223, 33);
			this.tambah.TabIndex = 6;
			this.tambah.Text = "TAMBAH";
			this.tambah.UseVisualStyleBackColor = true;
			this.tambah.Click += new System.EventHandler(this.TambahClick);
			// 
			// hapus
			// 
			this.hapus.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hapus.Location = new System.Drawing.Point(250, 441);
			this.hapus.Name = "hapus";
			this.hapus.Size = new System.Drawing.Size(205, 33);
			this.hapus.TabIndex = 7;
			this.hapus.Text = "HAPUS";
			this.hapus.UseVisualStyleBackColor = true;
			this.hapus.Click += new System.EventHandler(this.HapusClick);
			// 
			// update
			// 
			this.update.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.update.Location = new System.Drawing.Point(157, 511);
			this.update.Name = "update";
			this.update.Size = new System.Drawing.Size(157, 38);
			this.update.TabIndex = 8;
			this.update.Text = "UPDATE";
			this.update.UseVisualStyleBackColor = true;
			this.update.Click += new System.EventHandler(this.UpdateClick);
			// 
			// txtjudul
			// 
			this.txtjudul.Location = new System.Drawing.Point(132, 209);
			this.txtjudul.Name = "txtjudul";
			this.txtjudul.Size = new System.Drawing.Size(266, 20);
			this.txtjudul.TabIndex = 9;
			this.txtjudul.TextChanged += new System.EventHandler(this.TxtjudulTextChanged);
			// 
			// txtgenre
			// 
			this.txtgenre.Location = new System.Drawing.Point(132, 257);
			this.txtgenre.Name = "txtgenre";
			this.txtgenre.Size = new System.Drawing.Size(266, 20);
			this.txtgenre.TabIndex = 10;
			// 
			// txtkode
			// 
			this.txtkode.Location = new System.Drawing.Point(132, 297);
			this.txtkode.Name = "txtkode";
			this.txtkode.Size = new System.Drawing.Size(266, 20);
			this.txtkode.TabIndex = 11;
			// 
			// txtpenyanyi
			// 
			this.txtpenyanyi.Location = new System.Drawing.Point(132, 334);
			this.txtpenyanyi.Name = "txtpenyanyi";
			this.txtpenyanyi.Size = new System.Drawing.Size(266, 20);
			this.txtpenyanyi.TabIndex = 12;
			// 
			// txtalbum
			// 
			this.txtalbum.Location = new System.Drawing.Point(132, 370);
			this.txtalbum.Name = "txtalbum";
			this.txtalbum.Size = new System.Drawing.Size(266, 20);
			this.txtalbum.TabIndex = 13;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(489, 561);
			this.Controls.Add(this.txtalbum);
			this.Controls.Add(this.txtpenyanyi);
			this.Controls.Add(this.txtkode);
			this.Controls.Add(this.txtgenre);
			this.Controls.Add(this.txtjudul);
			this.Controls.Add(this.update);
			this.Controls.Add(this.hapus);
			this.Controls.Add(this.tambah);
			this.Controls.Add(this.album);
			this.Controls.Add(this.penyanyi);
			this.Controls.Add(this.kode);
			this.Controls.Add(this.genre_lagu);
			this.Controls.Add(this.judul);
			this.Controls.Add(this.dataGridView);
			this.Name = "MainForm";
			this.Text = "Spotify";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
