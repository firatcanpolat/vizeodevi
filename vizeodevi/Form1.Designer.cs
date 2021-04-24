
namespace vizeodevi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clbaslik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clhaber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "TRT HABER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clbaslik,
            this.clhaber,
            this.cltarih});
            this.dataGridView1.Location = new System.Drawing.Point(-5, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(804, 158);
            this.dataGridView1.TabIndex = 1;
            // 
            // clbaslik
            // 
            this.clbaslik.HeaderText = "baslik";
            this.clbaslik.MinimumWidth = 6;
            this.clbaslik.Name = "clbaslik";
            this.clbaslik.Width = 125;
            // 
            // clhaber
            // 
            this.clhaber.HeaderText = "haber";
            this.clhaber.MinimumWidth = 6;
            this.clhaber.Name = "clhaber";
            this.clhaber.Width = 125;
            // 
            // cltarih
            // 
            this.cltarih.HeaderText = "tarih";
            this.cltarih.MinimumWidth = 6;
            this.cltarih.Name = "cltarih";
            this.cltarih.Width = 125;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clbaslik;
        private System.Windows.Forms.DataGridViewTextBoxColumn clhaber;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltarih;
    }
}

