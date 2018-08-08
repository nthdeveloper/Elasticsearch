namespace ElasticsearchTestApp
{
    partial class FrmElasticsearchTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateClient = new System.Windows.Forms.Button();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateIndex = new System.Windows.Forms.Button();
            this.txtIndexName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddDocument = new System.Windows.Forms.Button();
            this.txtPostContent = new System.Windows.Forms.TextBox();
            this.numPostId = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.datePostDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdateDocument = new System.Windows.Forms.Button();
            this.btnDeleteDocument = new System.Windows.Forms.Button();
            this.btnDeleteIndex = new System.Windows.Forms.Button();
            this.btnGetDocument = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPostId)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCreateClient);
            this.groupBox1.Controls.Add(this.numPort);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtServer);
            this.groupBox1.Location = new System.Drawing.Point(8, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 152);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "(1) Connection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Server";
            // 
            // btnCreateClient
            // 
            this.btnCreateClient.Location = new System.Drawing.Point(120, 105);
            this.btnCreateClient.Name = "btnCreateClient";
            this.btnCreateClient.Size = new System.Drawing.Size(155, 32);
            this.btnCreateClient.TabIndex = 8;
            this.btnCreateClient.Text = "Create Client";
            this.btnCreateClient.UseVisualStyleBackColor = true;
            this.btnCreateClient.Click += new System.EventHandler(this.btnCreateClient_Click);
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(120, 67);
            this.numPort.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(155, 21);
            this.numPort.TabIndex = 7;
            this.numPort.Value = new decimal(new int[] {
            9200,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(120, 36);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(154, 21);
            this.txtServer.TabIndex = 4;
            this.txtServer.Text = "127.0.0.1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteIndex);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnCreateIndex);
            this.groupBox2.Controls.Add(this.txtIndexName);
            this.groupBox2.Location = new System.Drawing.Point(8, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 154);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "(2) Create / Delete Index";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // btnCreateIndex
            // 
            this.btnCreateIndex.Location = new System.Drawing.Point(120, 73);
            this.btnCreateIndex.Name = "btnCreateIndex";
            this.btnCreateIndex.Size = new System.Drawing.Size(155, 32);
            this.btnCreateIndex.TabIndex = 8;
            this.btnCreateIndex.Text = "Create Index";
            this.btnCreateIndex.UseVisualStyleBackColor = true;
            this.btnCreateIndex.Click += new System.EventHandler(this.btnCreateIndex_Click);
            // 
            // txtIndexName
            // 
            this.txtIndexName.Location = new System.Drawing.Point(120, 36);
            this.txtIndexName.Name = "txtIndexName";
            this.txtIndexName.Size = new System.Drawing.Size(154, 21);
            this.txtIndexName.TabIndex = 4;
            this.txtIndexName.Text = "blog";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGetDocument);
            this.groupBox3.Controls.Add(this.btnDeleteDocument);
            this.groupBox3.Controls.Add(this.btnUpdateDocument);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.datePostDate);
            this.groupBox3.Controls.Add(this.numPostId);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnAddDocument);
            this.groupBox3.Controls.Add(this.txtPostContent);
            this.groupBox3.Location = new System.Drawing.Point(319, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 310);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "(3) Add / Get / Update / Delete Document";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Text";
            // 
            // btnAddDocument
            // 
            this.btnAddDocument.Location = new System.Drawing.Point(120, 114);
            this.btnAddDocument.Name = "btnAddDocument";
            this.btnAddDocument.Size = new System.Drawing.Size(155, 32);
            this.btnAddDocument.TabIndex = 8;
            this.btnAddDocument.Text = "Add Document";
            this.btnAddDocument.UseVisualStyleBackColor = true;
            this.btnAddDocument.Click += new System.EventHandler(this.btnAddDocument_Click);
            // 
            // txtPostContent
            // 
            this.txtPostContent.Location = new System.Drawing.Point(120, 74);
            this.txtPostContent.Name = "txtPostContent";
            this.txtPostContent.Size = new System.Drawing.Size(154, 21);
            this.txtPostContent.TabIndex = 4;
            this.txtPostContent.Text = "Some content";
            // 
            // numPostId
            // 
            this.numPostId.Location = new System.Drawing.Point(120, 20);
            this.numPostId.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPostId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPostId.Name = "numPostId";
            this.numPostId.Size = new System.Drawing.Size(155, 21);
            this.numPostId.TabIndex = 10;
            this.numPostId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Id";
            // 
            // datePostDate
            // 
            this.datePostDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePostDate.Location = new System.Drawing.Point(120, 47);
            this.datePostDate.Name = "datePostDate";
            this.datePostDate.Size = new System.Drawing.Size(154, 21);
            this.datePostDate.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Date";
            // 
            // btnUpdateDocument
            // 
            this.btnUpdateDocument.Location = new System.Drawing.Point(120, 190);
            this.btnUpdateDocument.Name = "btnUpdateDocument";
            this.btnUpdateDocument.Size = new System.Drawing.Size(155, 32);
            this.btnUpdateDocument.TabIndex = 13;
            this.btnUpdateDocument.Text = "Update Document";
            this.btnUpdateDocument.UseVisualStyleBackColor = true;
            this.btnUpdateDocument.Click += new System.EventHandler(this.btnUpdateDocument_Click);
            // 
            // btnDeleteDocument
            // 
            this.btnDeleteDocument.Location = new System.Drawing.Point(119, 228);
            this.btnDeleteDocument.Name = "btnDeleteDocument";
            this.btnDeleteDocument.Size = new System.Drawing.Size(155, 32);
            this.btnDeleteDocument.TabIndex = 14;
            this.btnDeleteDocument.Text = "Delete Document";
            this.btnDeleteDocument.UseVisualStyleBackColor = true;
            this.btnDeleteDocument.Click += new System.EventHandler(this.btnDeleteDocument_Click);
            // 
            // btnDeleteIndex
            // 
            this.btnDeleteIndex.Location = new System.Drawing.Point(119, 111);
            this.btnDeleteIndex.Name = "btnDeleteIndex";
            this.btnDeleteIndex.Size = new System.Drawing.Size(155, 32);
            this.btnDeleteIndex.TabIndex = 9;
            this.btnDeleteIndex.Text = "Delete Index";
            this.btnDeleteIndex.UseVisualStyleBackColor = true;
            this.btnDeleteIndex.Click += new System.EventHandler(this.btnDeleteIndex_Click);
            // 
            // btnGetDocument
            // 
            this.btnGetDocument.Location = new System.Drawing.Point(120, 152);
            this.btnGetDocument.Name = "btnGetDocument";
            this.btnGetDocument.Size = new System.Drawing.Size(155, 32);
            this.btnGetDocument.TabIndex = 15;
            this.btnGetDocument.Text = "Get Document";
            this.btnGetDocument.UseVisualStyleBackColor = true;
            this.btnGetDocument.Click += new System.EventHandler(this.btnGetDocument_Click);
            // 
            // FrmElasticsearchTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 552);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FrmElasticsearchTest";
            this.Text = "Elasticsearch Test";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPostId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreateClient;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateIndex;
        private System.Windows.Forms.TextBox txtIndexName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDeleteDocument;
        private System.Windows.Forms.Button btnUpdateDocument;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datePostDate;
        private System.Windows.Forms.NumericUpDown numPostId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddDocument;
        private System.Windows.Forms.TextBox txtPostContent;
        private System.Windows.Forms.Button btnDeleteIndex;
        private System.Windows.Forms.Button btnGetDocument;
    }
}

