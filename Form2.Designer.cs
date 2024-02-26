namespace Такси
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label id_driverLabel;
            System.Windows.Forms.Label fioLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label telLabel;
            System.Windows.Forms.Label experienceLabel;
            System.Windows.Forms.Label tariff_idLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.taxiDataSet = new Такси.taxiDataSet();
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driverTableAdapter = new Такси.taxiDataSetTableAdapters.driverTableAdapter();
            this.tableAdapterManager = new Такси.taxiDataSetTableAdapters.TableAdapterManager();
            this.driverBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.id_driverTextBox = new System.Windows.Forms.TextBox();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.telTextBox = new System.Windows.Forms.TextBox();
            this.experienceTextBox = new System.Windows.Forms.TextBox();
            this.tariff_idTextBox = new System.Windows.Forms.TextBox();
            this.orderrTableAdapter = new Такси.taxiDataSetTableAdapters.orderrTableAdapter();
            this.tariffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tariffTableAdapter = new Такси.taxiDataSetTableAdapters.tariffTableAdapter();
            this.orderrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            id_driverLabel = new System.Windows.Forms.Label();
            fioLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            telLabel = new System.Windows.Forms.Label();
            experienceLabel = new System.Windows.Forms.Label();
            tariff_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingNavigator)).BeginInit();
            this.driverBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderrBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(219, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Водители";
            // 
            // taxiDataSet
            // 
            this.taxiDataSet.DataSetName = "taxiDataSet";
            this.taxiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataMember = "driver";
            this.driverBindingSource.DataSource = this.taxiDataSet;
            // 
            // driverTableAdapter
            // 
            this.driverTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.carTableAdapter = null;
            this.tableAdapterManager.driverTableAdapter = this.driverTableAdapter;
            this.tableAdapterManager.orderrTableAdapter = this.orderrTableAdapter;
            this.tableAdapterManager.tariffTableAdapter = this.tariffTableAdapter;
            this.tableAdapterManager.UpdateOrder = Такси.taxiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // driverBindingNavigator
            // 
            this.driverBindingNavigator.AddNewItem = null;
            this.driverBindingNavigator.BindingSource = this.driverBindingSource;
            this.driverBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.driverBindingNavigator.DeleteItem = null;
            this.driverBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.driverBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.driverBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.driverBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.driverBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.driverBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.driverBindingNavigator.Name = "driverBindingNavigator";
            this.driverBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.driverBindingNavigator.Size = new System.Drawing.Size(546, 25);
            this.driverBindingNavigator.TabIndex = 1;
            this.driverBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // id_driverLabel
            // 
            id_driverLabel.AutoSize = true;
            id_driverLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_driverLabel.Location = new System.Drawing.Point(115, 73);
            id_driverLabel.Name = "id_driverLabel";
            id_driverLabel.Size = new System.Drawing.Size(105, 25);
            id_driverLabel.TabIndex = 2;
            id_driverLabel.Text = "Позывной:";
            // 
            // id_driverTextBox
            // 
            this.id_driverTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "id_driver", true));
            this.id_driverTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_driverTextBox.Location = new System.Drawing.Point(223, 69);
            this.id_driverTextBox.Name = "id_driverTextBox";
            this.id_driverTextBox.Size = new System.Drawing.Size(82, 33);
            this.id_driverTextBox.TabIndex = 3;
            // 
            // fioLabel
            // 
            fioLabel.AutoSize = true;
            fioLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            fioLabel.Location = new System.Drawing.Point(161, 121);
            fioLabel.Name = "fioLabel";
            fioLabel.Size = new System.Drawing.Size(58, 25);
            fioLabel.TabIndex = 4;
            fioLabel.Text = "ФИО:";
            // 
            // fioTextBox
            // 
            this.fioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "fio", true));
            this.fioTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioTextBox.Location = new System.Drawing.Point(222, 116);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(285, 33);
            this.fioTextBox.TabIndex = 5;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            genderLabel.Location = new System.Drawing.Point(168, 165);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(51, 25);
            genderLabel.TabIndex = 6;
            genderLabel.Text = "Пол:";
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "gender", true));
            this.genderTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genderTextBox.Location = new System.Drawing.Point(222, 160);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(99, 33);
            this.genderTextBox.TabIndex = 7;
            // 
            // telLabel
            // 
            telLabel.AutoSize = true;
            telLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            telLabel.Location = new System.Drawing.Point(128, 206);
            telLabel.Name = "telLabel";
            telLabel.Size = new System.Drawing.Size(91, 25);
            telLabel.TabIndex = 8;
            telLabel.Text = "Телефон:";
            // 
            // telTextBox
            // 
            this.telTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "tel", true));
            this.telTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.telTextBox.Location = new System.Drawing.Point(222, 202);
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(143, 33);
            this.telTextBox.TabIndex = 9;
            // 
            // experienceLabel
            // 
            experienceLabel.AutoSize = true;
            experienceLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            experienceLabel.Location = new System.Drawing.Point(92, 245);
            experienceLabel.Name = "experienceLabel";
            experienceLabel.Size = new System.Drawing.Size(129, 25);
            experienceLabel.TabIndex = 10;
            experienceLabel.Text = "Стаж работы:";
            // 
            // experienceTextBox
            // 
            this.experienceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "experience", true));
            this.experienceTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.experienceTextBox.Location = new System.Drawing.Point(222, 241);
            this.experienceTextBox.Name = "experienceTextBox";
            this.experienceTextBox.Size = new System.Drawing.Size(83, 33);
            this.experienceTextBox.TabIndex = 11;
            // 
            // tariff_idLabel
            // 
            tariff_idLabel.AutoSize = true;
            tariff_idLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            tariff_idLabel.Location = new System.Drawing.Point(77, 291);
            tariff_idLabel.Name = "tariff_idLabel";
            tariff_idLabel.Size = new System.Drawing.Size(142, 25);
            tariff_idLabel.TabIndex = 12;
            tariff_idLabel.Text = "Номер тарифа:";
            // 
            // tariff_idTextBox
            // 
            this.tariff_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverBindingSource, "tariff_id", true));
            this.tariff_idTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tariff_idTextBox.Location = new System.Drawing.Point(222, 287);
            this.tariff_idTextBox.Name = "tariff_idTextBox";
            this.tariff_idTextBox.Size = new System.Drawing.Size(83, 33);
            this.tariff_idTextBox.TabIndex = 13;
            // 
            // orderrTableAdapter
            // 
            this.orderrTableAdapter.ClearBeforeFill = true;
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
            // orderrBindingSource
            // 
            this.orderrBindingSource.DataMember = "FK_driver";
            this.orderrBindingSource.DataSource = this.driverBindingSource;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 379);
            this.Controls.Add(this.button1);
            this.Controls.Add(tariff_idLabel);
            this.Controls.Add(this.tariff_idTextBox);
            this.Controls.Add(experienceLabel);
            this.Controls.Add(this.experienceTextBox);
            this.Controls.Add(telLabel);
            this.Controls.Add(this.telTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(fioLabel);
            this.Controls.Add(this.fioTextBox);
            this.Controls.Add(id_driverLabel);
            this.Controls.Add(this.id_driverTextBox);
            this.Controls.Add(this.driverBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Водители";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingNavigator)).EndInit();
            this.driverBindingNavigator.ResumeLayout(false);
            this.driverBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderrBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private taxiDataSet taxiDataSet;
        private System.Windows.Forms.BindingSource driverBindingSource;
        private taxiDataSetTableAdapters.driverTableAdapter driverTableAdapter;
        private taxiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator driverBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private taxiDataSetTableAdapters.orderrTableAdapter orderrTableAdapter;
        private System.Windows.Forms.TextBox id_driverTextBox;
        private System.Windows.Forms.TextBox fioTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox telTextBox;
        private System.Windows.Forms.TextBox experienceTextBox;
        private System.Windows.Forms.TextBox tariff_idTextBox;
        private System.Windows.Forms.BindingSource orderrBindingSource;
        private taxiDataSetTableAdapters.tariffTableAdapter tariffTableAdapter;
        private System.Windows.Forms.BindingSource tariffBindingSource;
        private System.Windows.Forms.Button button1;
    }
}