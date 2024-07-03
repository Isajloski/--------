namespace Милионер
{
    partial class Милионер
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Милионер));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.labelQuestion = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.labelB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.imageList1, "imageList1");
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // labelQuestion
            // 
            resources.ApplyResources(this.labelQuestion, "labelQuestion");
            this.labelQuestion.BackColor = System.Drawing.Color.Transparent;
            this.labelQuestion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Click += new System.EventHandler(this.label1_Click);
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.imageList2, "imageList2");
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // labelB
            // 
            resources.ApplyResources(this.labelB, "labelB");
            this.labelB.BackColor = System.Drawing.Color.Transparent;
            this.labelB.ForeColor = System.Drawing.Color.Transparent;
            this.labelB.Name = "labelB";
            this.labelB.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Name = "label3";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // Милионер
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.labelB);
            this.Name = "Милионер";
            this.Load += new System.EventHandler(this.Милионер_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

