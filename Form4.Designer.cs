namespace Такси
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.taxiDataSet = new Такси.taxiDataSet();
            this.orderrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderrTableAdapter = new Такси.taxiDataSetTableAdapters.orderrTableAdapter();
            this.tableAdapterManager = new Такси.taxiDataSetTableAdapters.TableAdapterManager();
            this.driverTableAdapter = new Такси.taxiDataSetTableAdapters.driverTableAdapter();
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaveButton = new System.Windows.Forms.Button();
            this.Txt_in = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Txt_from = new System.Windows.Forms.TextBox();
            this.Lbl_km = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.Btn_next = new System.Windows.Forms.Button();
            this.Btn_last = new System.Windows.Forms.Button();
            this.Txt_comm = new System.Windows.Forms.TextBox();
            this.tariffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tariffTableAdapter = new Такси.taxiDataSetTableAdapters.tariffTableAdapter();
            this.Txt_ttype = new System.Windows.Forms.TextBox();
            this.Btn_nnext = new System.Windows.Forms.Button();
            this.Btn_llast = new System.Windows.Forms.Button();
            this.Txt_gender = new System.Windows.Forms.TextBox();
            this.Btn_nnnext = new System.Windows.Forms.Button();
            this.Btn_lllast = new System.Windows.Forms.Button();
            this.Lbl_price = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(323, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заказ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(117, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 33);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ваше имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ваш номер телефона";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(215, 219);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 33);
            this.textBox2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Тариф";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(76, 324);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(146, 29);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Выбрать пол:";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.Location = new System.Drawing.Point(12, 367);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(308, 29);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Выбрать конкретного водителя:";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // taxiDataSet
            // 
            this.taxiDataSet.DataSetName = "taxiDataSet";
            this.taxiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderrBindingSource
            // 
            this.orderrBindingSource.DataMember = "orderr";
            this.orderrBindingSource.DataSource = this.taxiDataSet;
            // 
            // orderrTableAdapter
            // 
            this.orderrTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.carTableAdapter = null;
            this.tableAdapterManager.driverTableAdapter = this.driverTableAdapter;
            this.tableAdapterManager.orderrTableAdapter = this.orderrTableAdapter;
            this.tableAdapterManager.tariffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Такси.taxiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // driverTableAdapter
            // 
            this.driverTableAdapter.ClearBeforeFill = true;
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataMember = "driver";
            this.driverBindingSource.DataSource = this.taxiDataSet;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SaveButton.Location = new System.Drawing.Point(494, 523);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(138, 36);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Отправить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Txt_in
            // 
            this.Txt_in.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Txt_in.Location = new System.Drawing.Point(73, 114);
            this.Txt_in.Name = "Txt_in";
            this.Txt_in.Size = new System.Drawing.Size(365, 33);
            this.Txt_in.TabIndex = 18;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(662, 516);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(116, 51);
            this.DeleteButton.TabIndex = 20;
            this.DeleteButton.Text = "Отменить запись";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Txt_from
            // 
            this.Txt_from.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Txt_from.Location = new System.Drawing.Point(97, 65);
            this.Txt_from.Name = "Txt_from";
            this.Txt_from.Size = new System.Drawing.Size(365, 33);
            this.Txt_from.TabIndex = 21;
            // 
            // Lbl_km
            // 
            this.Lbl_km.AutoSize = true;
            this.Lbl_km.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_km.Location = new System.Drawing.Point(735, 170);
            this.Lbl_km.Name = "Lbl_km";
            this.Lbl_km.Size = new System.Drawing.Size(30, 25);
            this.Lbl_km.TabIndex = 22;
            this.Lbl_km.Text = "??";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton1,
            this.toolStripSeparator1,
            this.ToolStripButton2,
            this.toolStripSeparator2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(799, 27);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ToolStripButton1
            // 
            this.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton1.Image")));
            this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton1.Name = "ToolStripButton1";
            this.ToolStripButton1.Size = new System.Drawing.Size(126, 24);
            this.ToolStripButton1.Text = "Список тарифов";
            this.ToolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // ToolStripButton2
            // 
            this.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton2.Image")));
            this.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton2.Name = "ToolStripButton2";
            this.ToolStripButton2.Size = new System.Drawing.Size(140, 24);
            this.ToolStripButton2.Text = "Список водителей";
            this.ToolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(57, 24);
            this.toolStripButton3.Text = "Выход";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // fioTextBox
            // 
            this.fioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "fio", true));
            this.fioTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioTextBox.Location = new System.Drawing.Point(360, 367);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(198, 33);
            this.fioTextBox.TabIndex = 24;
            // 
            // Btn_next
            // 
            this.Btn_next.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_next.Image = ((System.Drawing.Image)(resources.GetObject("Btn_next.Image")));
            this.Btn_next.Location = new System.Drawing.Point(564, 371);
            this.Btn_next.Name = "Btn_next";
            this.Btn_next.Size = new System.Drawing.Size(26, 23);
            this.Btn_next.TabIndex = 25;
            this.Btn_next.UseVisualStyleBackColor = true;
            this.Btn_next.Click += new System.EventHandler(this.Btn_next_Click);
            // 
            // Btn_last
            // 
            this.Btn_last.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_last.Image = ((System.Drawing.Image)(resources.GetObject("Btn_last.Image")));
            this.Btn_last.Location = new System.Drawing.Point(326, 372);
            this.Btn_last.Name = "Btn_last";
            this.Btn_last.Size = new System.Drawing.Size(29, 23);
            this.Btn_last.TabIndex = 26;
            this.Btn_last.UseVisualStyleBackColor = true;
            this.Btn_last.Click += new System.EventHandler(this.Btn_last_Click);
            // 
            // Txt_comm
            // 
            this.Txt_comm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Txt_comm.Location = new System.Drawing.Point(33, 442);
            this.Txt_comm.Multiline = true;
            this.Txt_comm.Name = "Txt_comm";
            this.Txt_comm.Size = new System.Drawing.Size(347, 121);
            this.Txt_comm.TabIndex = 27;
            // 
            // tariffBindingSource
            // 
            this.tariffBindingSource.DataMember = "tariff";
            this.tariffBindingSource.DataSource = this.taxiDataSet;
            // 
            // tariffTableAdapter
            // 
            this.tariffTableAdapter.ClearBeforeFill = true;
            // 
            // Txt_ttype
            // 
            this.Txt_ttype.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tariffBindingSource, "ttype", true));
            this.Txt_ttype.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Txt_ttype.Location = new System.Drawing.Point(150, 264);
            this.Txt_ttype.Name = "Txt_ttype";
            this.Txt_ttype.Size = new System.Drawing.Size(148, 33);
            this.Txt_ttype.TabIndex = 28;
            this.Txt_ttype.TextChanged += new System.EventHandler(this.Txt_ttype_TextChanged);
            // 
            // Btn_nnext
            // 
            this.Btn_nnext.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_nnext.Image = ((System.Drawing.Image)(resources.GetObject("Btn_nnext.Image")));
            this.Btn_nnext.Location = new System.Drawing.Point(311, 268);
            this.Btn_nnext.Name = "Btn_nnext";
            this.Btn_nnext.Size = new System.Drawing.Size(27, 23);
            this.Btn_nnext.TabIndex = 29;
            this.Btn_nnext.UseVisualStyleBackColor = true;
            this.Btn_nnext.Click += new System.EventHandler(this.Btn_nnext_Click);
            // 
            // Btn_llast
            // 
            this.Btn_llast.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_llast.Image = ((System.Drawing.Image)(resources.GetObject("Btn_llast.Image")));
            this.Btn_llast.Location = new System.Drawing.Point(115, 268);
            this.Btn_llast.Name = "Btn_llast";
            this.Btn_llast.Size = new System.Drawing.Size(29, 23);
            this.Btn_llast.TabIndex = 30;
            this.Btn_llast.UseVisualStyleBackColor = true;
            this.Btn_llast.Click += new System.EventHandler(this.Btn_llast_Click);
            // 
            // Txt_gender
            // 
            this.Txt_gender.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "gender", true));
            this.Txt_gender.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Txt_gender.Location = new System.Drawing.Point(361, 320);
            this.Txt_gender.Name = "Txt_gender";
            this.Txt_gender.Size = new System.Drawing.Size(121, 33);
            this.Txt_gender.TabIndex = 31;
            // 
            // Btn_nnnext
            // 
            this.Btn_nnnext.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_nnnext.Image = ((System.Drawing.Image)(resources.GetObject("Btn_nnnext.Image")));
            this.Btn_nnnext.Location = new System.Drawing.Point(488, 325);
            this.Btn_nnnext.Name = "Btn_nnnext";
            this.Btn_nnnext.Size = new System.Drawing.Size(26, 23);
            this.Btn_nnnext.TabIndex = 32;
            this.Btn_nnnext.UseVisualStyleBackColor = true;
            this.Btn_nnnext.Click += new System.EventHandler(this.Btn_nnnext_Click);
            // 
            // Btn_lllast
            // 
            this.Btn_lllast.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_lllast.Image = ((System.Drawing.Image)(resources.GetObject("Btn_lllast.Image")));
            this.Btn_lllast.Location = new System.Drawing.Point(329, 324);
            this.Btn_lllast.Name = "Btn_lllast";
            this.Btn_lllast.Size = new System.Drawing.Size(26, 23);
            this.Btn_lllast.TabIndex = 33;
            this.Btn_lllast.UseVisualStyleBackColor = true;
            this.Btn_lllast.Click += new System.EventHandler(this.Btn_lllast_Click);
            // 
            // Lbl_price
            // 
            this.Lbl_price.AutoSize = true;
            this.Lbl_price.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_price.Location = new System.Drawing.Point(722, 209);
            this.Lbl_price.Name = "Lbl_price";
            this.Lbl_price.Size = new System.Drawing.Size(22, 25);
            this.Lbl_price.TabIndex = 34;
            this.Lbl_price.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(104, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Комментарий к заказу";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(608, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 36;
            this.label6.Text = "Цена/руб:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(595, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 25);
            this.label7.TabIndex = 37;
            this.label7.Text = "Расстояние/км:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(13, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 25);
            this.label8.TabIndex = 38;
            this.label8.Text = "Откуда";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 25);
            this.label9.TabIndex = 39;
            this.label9.Text = "Куда";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(482, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "p.s.";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 575);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Lbl_price);
            this.Controls.Add(this.Btn_lllast);
            this.Controls.Add(this.Btn_nnnext);
            this.Controls.Add(this.Txt_gender);
            this.Controls.Add(this.Btn_llast);
            this.Controls.Add(this.Btn_nnext);
            this.Controls.Add(this.Txt_ttype);
            this.Controls.Add(this.Txt_comm);
            this.Controls.Add(this.Btn_last);
            this.Controls.Add(this.Btn_next);
            this.Controls.Add(this.fioTextBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Lbl_km);
            this.Controls.Add(this.Txt_from);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.Txt_in);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Форма оформления заявки";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private taxiDataSet taxiDataSet;
        private System.Windows.Forms.BindingSource orderrBindingSource;
        private taxiDataSetTableAdapters.orderrTableAdapter orderrTableAdapter;
        private taxiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private taxiDataSetTableAdapters.driverTableAdapter driverTableAdapter;
        private System.Windows.Forms.BindingSource driverBindingSource;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox Txt_in;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox Txt_from;
        private System.Windows.Forms.Label Lbl_km;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ToolStripButton1;
        private System.Windows.Forms.ToolStripButton ToolStripButton2;
        private System.Windows.Forms.TextBox fioTextBox;
        private System.Windows.Forms.Button Btn_next;
        private System.Windows.Forms.Button Btn_last;
        private System.Windows.Forms.TextBox Txt_comm;
        private System.Windows.Forms.BindingSource tariffBindingSource;
        private taxiDataSetTableAdapters.tariffTableAdapter tariffTableAdapter;
        private System.Windows.Forms.TextBox Txt_ttype;
        private System.Windows.Forms.Button Btn_nnext;
        private System.Windows.Forms.Button Btn_llast;
        private System.Windows.Forms.TextBox Txt_gender;
        private System.Windows.Forms.Button Btn_nnnext;
        private System.Windows.Forms.Button Btn_lllast;
        private System.Windows.Forms.Label Lbl_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Label label10;
    }
}