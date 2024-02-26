namespace Такси
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.Label id_tariffLabel;
            System.Windows.Forms.Label ttypeLabel;
            System.Windows.Forms.Label price_minLabel;
            System.Windows.Forms.Label free_waiting_minLabel;
            System.Windows.Forms.Label price_min_waitingLabel;
            this.taxiDataSet = new Такси.taxiDataSet();
            this.tariffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tariffTableAdapter = new Такси.taxiDataSetTableAdapters.tariffTableAdapter();
            this.tableAdapterManager = new Такси.taxiDataSetTableAdapters.TableAdapterManager();
            this.tariffBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.id_tariffTextBox = new System.Windows.Forms.TextBox();
            this.ttypeTextBox = new System.Windows.Forms.TextBox();
            this.price_minTextBox = new System.Windows.Forms.TextBox();
            this.free_waiting_minTextBox = new System.Windows.Forms.TextBox();
            this.price_min_waitingTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            id_tariffLabel = new System.Windows.Forms.Label();
            ttypeLabel = new System.Windows.Forms.Label();
            price_minLabel = new System.Windows.Forms.Label();
            free_waiting_minLabel = new System.Windows.Forms.Label();
            price_min_waitingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingNavigator)).BeginInit();
            this.tariffBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // taxiDataSet
            // 
            this.taxiDataSet.DataSetName = "taxiDataSet";
            this.taxiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.carTableAdapter = null;
            this.tableAdapterManager.driverTableAdapter = null;
            this.tableAdapterManager.orderrTableAdapter = null;
            this.tableAdapterManager.tariffTableAdapter = this.tariffTableAdapter;
            this.tableAdapterManager.UpdateOrder = Такси.taxiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tariffBindingNavigator
            // 
            this.tariffBindingNavigator.AddNewItem = null;
            this.tariffBindingNavigator.BindingSource = this.tariffBindingSource;
            this.tariffBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tariffBindingNavigator.DeleteItem = null;
            this.tariffBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.tariffBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tariffBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tariffBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tariffBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tariffBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tariffBindingNavigator.Name = "tariffBindingNavigator";
            this.tariffBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tariffBindingNavigator.Size = new System.Drawing.Size(546, 25);
            this.tariffBindingNavigator.TabIndex = 0;
            this.tariffBindingNavigator.Text = "bindingNavigator1";
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
            // id_tariffLabel
            // 
            id_tariffLabel.AutoSize = true;
            id_tariffLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_tariffLabel.Location = new System.Drawing.Point(166, 80);
            id_tariffLabel.Name = "id_tariffLabel";
            id_tariffLabel.Size = new System.Drawing.Size(142, 25);
            id_tariffLabel.TabIndex = 1;
            id_tariffLabel.Text = "Номер тарифа:";
            // 
            // id_tariffTextBox
            // 
            this.id_tariffTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tariffBindingSource, "id_tariff", true));
            this.id_tariffTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_tariffTextBox.Location = new System.Drawing.Point(314, 77);
            this.id_tariffTextBox.Name = "id_tariffTextBox";
            this.id_tariffTextBox.Size = new System.Drawing.Size(100, 33);
            this.id_tariffTextBox.TabIndex = 2;
            // 
            // ttypeLabel
            // 
            ttypeLabel.AutoSize = true;
            ttypeLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ttypeLabel.Location = new System.Drawing.Point(211, 130);
            ttypeLabel.Name = "ttypeLabel";
            ttypeLabel.Size = new System.Drawing.Size(99, 25);
            ttypeLabel.TabIndex = 3;
            ttypeLabel.Text = "Название:";
            // 
            // ttypeTextBox
            // 
            this.ttypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tariffBindingSource, "ttype", true));
            this.ttypeTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ttypeTextBox.Location = new System.Drawing.Point(316, 126);
            this.ttypeTextBox.Name = "ttypeTextBox";
            this.ttypeTextBox.Size = new System.Drawing.Size(155, 33);
            this.ttypeTextBox.TabIndex = 4;
            // 
            // price_minLabel
            // 
            price_minLabel.AutoSize = true;
            price_minLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            price_minLabel.Location = new System.Drawing.Point(130, 183);
            price_minLabel.Name = "price_minLabel";
            price_minLabel.Size = new System.Drawing.Size(178, 25);
            price_minLabel.TabIndex = 5;
            price_minLabel.Text = "Цена поездки/мин:";
            // 
            // price_minTextBox
            // 
            this.price_minTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tariffBindingSource, "price_min", true));
            this.price_minTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_minTextBox.Location = new System.Drawing.Point(315, 179);
            this.price_minTextBox.Name = "price_minTextBox";
            this.price_minTextBox.Size = new System.Drawing.Size(100, 33);
            this.price_minTextBox.TabIndex = 6;
            // 
            // free_waiting_minLabel
            // 
            free_waiting_minLabel.AutoSize = true;
            free_waiting_minLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            free_waiting_minLabel.Location = new System.Drawing.Point(54, 229);
            free_waiting_minLabel.Name = "free_waiting_minLabel";
            free_waiting_minLabel.Size = new System.Drawing.Size(252, 25);
            free_waiting_minLabel.TabIndex = 7;
            free_waiting_minLabel.Text = "Бесплатное ожидание/мин:";
            // 
            // free_waiting_minTextBox
            // 
            this.free_waiting_minTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tariffBindingSource, "free_waiting_min", true));
            this.free_waiting_minTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.free_waiting_minTextBox.Location = new System.Drawing.Point(313, 225);
            this.free_waiting_minTextBox.Name = "free_waiting_minTextBox";
            this.free_waiting_minTextBox.Size = new System.Drawing.Size(100, 33);
            this.free_waiting_minTextBox.TabIndex = 8;
            // 
            // price_min_waitingLabel
            // 
            price_min_waitingLabel.AutoSize = true;
            price_min_waitingLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            price_min_waitingLabel.Location = new System.Drawing.Point(11, 281);
            price_min_waitingLabel.Name = "price_min_waitingLabel";
            price_min_waitingLabel.Size = new System.Drawing.Size(295, 25);
            price_min_waitingLabel.TabIndex = 9;
            price_min_waitingLabel.Text = "Цена за платное ожидание/мин:";
            // 
            // price_min_waitingTextBox
            // 
            this.price_min_waitingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tariffBindingSource, "price_min_waiting", true));
            this.price_min_waitingTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_min_waitingTextBox.Location = new System.Drawing.Point(312, 277);
            this.price_min_waitingTextBox.Name = "price_min_waitingTextBox";
            this.price_min_waitingTextBox.Size = new System.Drawing.Size(100, 33);
            this.price_min_waitingTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(214, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Тарифы";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(16, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 379);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(price_min_waitingLabel);
            this.Controls.Add(this.price_min_waitingTextBox);
            this.Controls.Add(free_waiting_minLabel);
            this.Controls.Add(this.free_waiting_minTextBox);
            this.Controls.Add(price_minLabel);
            this.Controls.Add(this.price_minTextBox);
            this.Controls.Add(ttypeLabel);
            this.Controls.Add(this.ttypeTextBox);
            this.Controls.Add(id_tariffLabel);
            this.Controls.Add(this.id_tariffTextBox);
            this.Controls.Add(this.tariffBindingNavigator);
            this.Name = "Form3";
            this.Text = "Тарифы";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taxiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingNavigator)).EndInit();
            this.tariffBindingNavigator.ResumeLayout(false);
            this.tariffBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private taxiDataSet taxiDataSet;
        private System.Windows.Forms.BindingSource tariffBindingSource;
        private taxiDataSetTableAdapters.tariffTableAdapter tariffTableAdapter;
        private taxiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tariffBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.TextBox id_tariffTextBox;
        private System.Windows.Forms.TextBox ttypeTextBox;
        private System.Windows.Forms.TextBox price_minTextBox;
        private System.Windows.Forms.TextBox free_waiting_minTextBox;
        private System.Windows.Forms.TextBox price_min_waitingTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}