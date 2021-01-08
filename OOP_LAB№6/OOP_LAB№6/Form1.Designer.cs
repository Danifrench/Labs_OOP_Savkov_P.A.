
namespace OOP_LAB_6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.addElementButton = new System.Windows.Forms.Button();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.filterItemCost = new System.Windows.Forms.DomainUpDown();
            this.filterItemKkal = new System.Windows.Forms.DomainUpDown();
            this.filterItemWeight = new System.Windows.Forms.DomainUpDown();
            this.filterItemSize = new System.Windows.Forms.DomainUpDown();
            this.filterItemMaterial = new System.Windows.Forms.DomainUpDown();
            this.SuspendLayout();
            // 
            // addElementButton
            // 
            this.addElementButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(212)))), ((int)(((byte)(48)))));
            this.addElementButton.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addElementButton.ForeColor = System.Drawing.Color.MintCream;
            this.addElementButton.Location = new System.Drawing.Point(537, 362);
            this.addElementButton.Name = "addElementButton";
            this.addElementButton.Size = new System.Drawing.Size(262, 78);
            this.addElementButton.TabIndex = 0;
            this.addElementButton.Text = "ADD PRODUCT";
            this.addElementButton.UseVisualStyleBackColor = false;
            this.addElementButton.Click += new System.EventHandler(this.addElementButton_Click);
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 16;
            this.listBoxProducts.Location = new System.Drawing.Point(12, 12);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(514, 340);
            this.listBoxProducts.TabIndex = 1;
            this.listBoxProducts.SelectedIndexChanged += new System.EventHandler(this.listBoxProducts_SelectedIndexChanged);
            // 
            // listBoxItems
            // 
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.ItemHeight = 16;
            this.listBoxItems.Location = new System.Drawing.Point(537, 12);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(262, 340);
            this.listBoxItems.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(38)))), ((int)(((byte)(63)))));
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.MintCream;
            this.button1.Location = new System.Drawing.Point(537, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // filterItemCost
            // 
            this.filterItemCost.Location = new System.Drawing.Point(12, 362);
            this.filterItemCost.Name = "filterItemCost";
            this.filterItemCost.Size = new System.Drawing.Size(514, 22);
            this.filterItemCost.TabIndex = 5;
            this.filterItemCost.Text = "Cost";
            this.filterItemCost.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // filterItemKkal
            // 
            this.filterItemKkal.Location = new System.Drawing.Point(12, 390);
            this.filterItemKkal.Name = "filterItemKkal";
            this.filterItemKkal.Size = new System.Drawing.Size(514, 22);
            this.filterItemKkal.TabIndex = 6;
            this.filterItemKkal.Text = "kkal";
            // 
            // filterItemWeight
            // 
            this.filterItemWeight.Location = new System.Drawing.Point(12, 418);
            this.filterItemWeight.Name = "filterItemWeight";
            this.filterItemWeight.Size = new System.Drawing.Size(514, 22);
            this.filterItemWeight.TabIndex = 7;
            this.filterItemWeight.Text = "Weight";
            // 
            // filterItemSize
            // 
            this.filterItemSize.Location = new System.Drawing.Point(12, 446);
            this.filterItemSize.Name = "filterItemSize";
            this.filterItemSize.Size = new System.Drawing.Size(514, 22);
            this.filterItemSize.TabIndex = 8;
            this.filterItemSize.Text = "Size";
            // 
            // filterItemMaterial
            // 
            this.filterItemMaterial.Location = new System.Drawing.Point(12, 474);
            this.filterItemMaterial.Name = "filterItemMaterial";
            this.filterItemMaterial.Size = new System.Drawing.Size(514, 22);
            this.filterItemMaterial.TabIndex = 9;
            this.filterItemMaterial.Text = "Material";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(811, 512);
            this.Controls.Add(this.filterItemMaterial);
            this.Controls.Add(this.filterItemSize);
            this.Controls.Add(this.filterItemWeight);
            this.Controls.Add(this.filterItemKkal);
            this.Controls.Add(this.filterItemCost);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxItems);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.addElementButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addElementButton;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DomainUpDown filterItemCost;
        private System.Windows.Forms.DomainUpDown filterItemKkal;
        private System.Windows.Forms.DomainUpDown filterItemWeight;
        private System.Windows.Forms.DomainUpDown filterItemSize;
        private System.Windows.Forms.DomainUpDown filterItemMaterial;
    }
}

