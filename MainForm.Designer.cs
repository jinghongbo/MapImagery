namespace MapImagery
{
    partial class MainForm
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
            this.mapViewer1 = new MapImagery.MapViewer();
            this.SuspendLayout();
            // 
            // mapViewer1
            // 
            this.mapViewer1.BackColor = System.Drawing.Color.White;
            this.mapViewer1.Location = new System.Drawing.Point(35, 167);
            this.mapViewer1.Name = "mapViewer1";
            this.mapViewer1.Size = new System.Drawing.Size(710, 237);
            this.mapViewer1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mapViewer1);
            this.Name = "MainForm";
            this.Text = "Map Imagery";
            this.ResumeLayout(false);

        }

        #endregion

        private MapViewer mapViewer1;
    }
}

