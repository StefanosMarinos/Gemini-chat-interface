namespace telikiergasia2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            αρχείοToolStripMenuItem = new ToolStripMenuItem();
            νέοςΔιάλογοςToolStripMenuItem = new ToolStripMenuItem();
            εισαγωγηΕρώτησηςtxtToolStripMenuItem = new ToolStripMenuItem();
            εξαγωγηΔιαλόγουtxtToolStripMenuItem = new ToolStripMenuItem();
            έξοδοςToolStripMenuItem = new ToolStripMenuItem();
            βάσηΔεδομένωνToolStripMenuItem = new ToolStripMenuItem();
            αποθήκευσηΤρέχουσαςΑπάντησηςToolStripMenuItem = new ToolStripMenuItem();
            προβοληΙστορικούToolStripMenuItem = new ToolStripMenuItem();
            σχετικάToolStripMenuItem = new ToolStripMenuItem();
            ηΟμάδαΜαςToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { αρχείοToolStripMenuItem, βάσηΔεδομένωνToolStripMenuItem, σχετικάToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // αρχείοToolStripMenuItem
            // 
            αρχείοToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { νέοςΔιάλογοςToolStripMenuItem, εισαγωγηΕρώτησηςtxtToolStripMenuItem, εξαγωγηΔιαλόγουtxtToolStripMenuItem, έξοδοςToolStripMenuItem });
            αρχείοToolStripMenuItem.Name = "αρχείοToolStripMenuItem";
            αρχείοToolStripMenuItem.Size = new Size(70, 24);
            αρχείοToolStripMenuItem.Text = "Αρχείο";
            // 
            // νέοςΔιάλογοςToolStripMenuItem
            // 
            νέοςΔιάλογοςToolStripMenuItem.Name = "νέοςΔιάλογοςToolStripMenuItem";
            νέοςΔιάλογοςToolStripMenuItem.Size = new Size(263, 26);
            νέοςΔιάλογοςToolStripMenuItem.Text = "Νέος Διάλογος";
            νέοςΔιάλογοςToolStripMenuItem.Click += νέοςΔιάλογοςToolStripMenuItem_Click;
            // 
            // εισαγωγηΕρώτησηςtxtToolStripMenuItem
            // 
            εισαγωγηΕρώτησηςtxtToolStripMenuItem.Name = "εισαγωγηΕρώτησηςtxtToolStripMenuItem";
            εισαγωγηΕρώτησηςtxtToolStripMenuItem.Size = new Size(263, 26);
            εισαγωγηΕρώτησηςtxtToolStripMenuItem.Text = "Εισαγωγη Ερώτησης(.txt)";
            εισαγωγηΕρώτησηςtxtToolStripMenuItem.Click += εισαγωγηΕρώτησηςtxtToolStripMenuItem_Click;
            // 
            // εξαγωγηΔιαλόγουtxtToolStripMenuItem
            // 
            εξαγωγηΔιαλόγουtxtToolStripMenuItem.Name = "εξαγωγηΔιαλόγουtxtToolStripMenuItem";
            εξαγωγηΔιαλόγουtxtToolStripMenuItem.Size = new Size(263, 26);
            εξαγωγηΔιαλόγουtxtToolStripMenuItem.Text = "Εξαγωγη Διαλόγου (.txt)";
            εξαγωγηΔιαλόγουtxtToolStripMenuItem.Click += εξαγωγηΔιαλόγουtxtToolStripMenuItem_Click;
            // 
            // έξοδοςToolStripMenuItem
            // 
            έξοδοςToolStripMenuItem.Name = "έξοδοςToolStripMenuItem";
            έξοδοςToolStripMenuItem.Size = new Size(263, 26);
            έξοδοςToolStripMenuItem.Text = "Έξοδος";
            έξοδοςToolStripMenuItem.Click += έξοδοςToolStripMenuItem_Click;
            // 
            // βάσηΔεδομένωνToolStripMenuItem
            // 
            βάσηΔεδομένωνToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { αποθήκευσηΤρέχουσαςΑπάντησηςToolStripMenuItem, προβοληΙστορικούToolStripMenuItem });
            βάσηΔεδομένωνToolStripMenuItem.Name = "βάσηΔεδομένωνToolStripMenuItem";
            βάσηΔεδομένωνToolStripMenuItem.Size = new Size(142, 24);
            βάσηΔεδομένωνToolStripMenuItem.Text = "Βάση Δεδομένων";
            // 
            // αποθήκευσηΤρέχουσαςΑπάντησηςToolStripMenuItem
            // 
            αποθήκευσηΤρέχουσαςΑπάντησηςToolStripMenuItem.Name = "αποθήκευσηΤρέχουσαςΑπάντησηςToolStripMenuItem";
            αποθήκευσηΤρέχουσαςΑπάντησηςToolStripMenuItem.Size = new Size(338, 26);
            αποθήκευσηΤρέχουσαςΑπάντησηςToolStripMenuItem.Text = "Αποθήκευση Τρέχουσας Απάντησης";
            αποθήκευσηΤρέχουσαςΑπάντησηςToolStripMenuItem.Click += αποθήκευσηΤρέχουσαςΑπάντησηςToolStripMenuItem_Click;
            // 
            // προβοληΙστορικούToolStripMenuItem
            // 
            προβοληΙστορικούToolStripMenuItem.Name = "προβοληΙστορικούToolStripMenuItem";
            προβοληΙστορικούToolStripMenuItem.Size = new Size(338, 26);
            προβοληΙστορικούToolStripMenuItem.Text = "Προβολη Ιστορικού";
            προβοληΙστορικούToolStripMenuItem.Click += προβοληΙστορικούToolStripMenuItem_Click;
            // 
            // σχετικάToolStripMenuItem
            // 
            σχετικάToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ηΟμάδαΜαςToolStripMenuItem });
            σχετικάToolStripMenuItem.Name = "σχετικάToolStripMenuItem";
            σχετικάToolStripMenuItem.Size = new Size(74, 24);
            σχετικάToolStripMenuItem.Text = "Σχετικά";
            // 
            // ηΟμάδαΜαςToolStripMenuItem
            // 
            ηΟμάδαΜαςToolStripMenuItem.Name = "ηΟμάδαΜαςToolStripMenuItem";
            ηΟμάδαΜαςToolStripMenuItem.Size = new Size(181, 26);
            ηΟμάδαΜαςToolStripMenuItem.Text = "Η ομάδα μας";
            ηΟμάδαΜαςToolStripMenuItem.Click += ηΟμάδαΜαςToolStripMenuItem_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 69);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(776, 289);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 379);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(492, 53);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(571, 379);
            button1.Name = "button1";
            button1.Size = new Size(173, 53);
            button1.TabIndex = 3;
            button1.Text = "Αποστολή";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(122, 28);
            label1.TabIndex = 4;
            label1.Text = "Gemini chat";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem αρχείοToolStripMenuItem;
        private ToolStripMenuItem βάσηΔεδομένωνToolStripMenuItem;
        private ToolStripMenuItem σχετικάToolStripMenuItem;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private ToolStripMenuItem νέοςΔιάλογοςToolStripMenuItem;
        private ToolStripMenuItem εισαγωγηΕρώτησηςtxtToolStripMenuItem;
        private ToolStripMenuItem εξαγωγηΔιαλόγουtxtToolStripMenuItem;
        private ToolStripMenuItem έξοδοςToolStripMenuItem;
        private ToolStripMenuItem αποθήκευσηΤρέχουσαςΑπάντησηςToolStripMenuItem;
        private ToolStripMenuItem προβοληΙστορικούToolStripMenuItem;
        private ToolStripMenuItem ηΟμάδαΜαςToolStripMenuItem;
    }
}
