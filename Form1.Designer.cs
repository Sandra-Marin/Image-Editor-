namespace Processing
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
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            printToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            clearImageToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            zoomToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripMenuItem();
            toolStripMenuItem9 = new ToolStripMenuItem();
            thumbnailViewToolStripMenuItem = new ToolStripMenuItem();
            colorFiltersToolStripMenuItem = new ToolStripMenuItem();
            filterToolStripMenuItem = new ToolStripMenuItem();
            redFilterToolStripMenuItem = new ToolStripMenuItem();
            greenFilterToolStripMenuItem = new ToolStripMenuItem();
            blueFilterToolStripMenuItem = new ToolStripMenuItem();
            greyscaleToolStripMenuItem = new ToolStripMenuItem();
            sepiaToneToolStripMenuItem = new ToolStripMenuItem();
            invertToolStripMenuItem = new ToolStripMenuItem();
            imageToolStripMenuItem = new ToolStripMenuItem();
            resizeToolStripMenuItem = new ToolStripMenuItem();
            rotateAndFlipToolStripMenuItem = new ToolStripMenuItem();
            flipHorizontalToolStripMenuItem = new ToolStripMenuItem();
            flipVerticalToolStripMenuItem = new ToolStripMenuItem();
            rotate90DegreesToolStripMenuItem = new ToolStripMenuItem();
            rotate180DegreesToolStripMenuItem = new ToolStripMenuItem();
            rotate270DegreesToolStripMenuItem = new ToolStripMenuItem();
            customRotateToolStripMenuItem = new ToolStripMenuItem();
            insertToolStripMenuItem = new ToolStripMenuItem();
            textToolStripMenuItem = new ToolStripMenuItem();
            imageToolStripMenuItem1 = new ToolStripMenuItem();
            twoImageToolStripMenuItem = new ToolStripMenuItem();
            checkersToolStripMenuItem = new ToolStripMenuItem();
            mergeToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar3 = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientActiveCaption;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, colorFiltersToolStripMenuItem, imageToolStripMenuItem, insertToolStripMenuItem, twoImageToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1781, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, printToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(224, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(224, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.Size = new Size(224, 26);
            printToolStripMenuItem.Text = "Print";
            printToolStripMenuItem.Click += printToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, clearImageToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(172, 26);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // clearImageToolStripMenuItem
            // 
            clearImageToolStripMenuItem.Name = "clearImageToolStripMenuItem";
            clearImageToolStripMenuItem.Size = new Size(172, 26);
            clearImageToolStripMenuItem.Text = "Clear Image";
            clearImageToolStripMenuItem.Click += clearImageToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zoomToolStripMenuItem, thumbnailViewToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // zoomToolStripMenuItem
            // 
            zoomToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, toolStripMenuItem6, toolStripMenuItem7, toolStripMenuItem8, toolStripMenuItem9 });
            zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            zoomToolStripMenuItem.Size = new Size(198, 26);
            zoomToolStripMenuItem.Text = "Zoom";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(128, 26);
            toolStripMenuItem2.Text = "25%";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(128, 26);
            toolStripMenuItem3.Text = "50%";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(128, 26);
            toolStripMenuItem4.Text = "100%";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(128, 26);
            toolStripMenuItem5.Text = "150%";
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(128, 26);
            toolStripMenuItem6.Text = "200%";
            toolStripMenuItem6.Click += toolStripMenuItem6_Click;
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(128, 26);
            toolStripMenuItem7.Text = "300%";
            toolStripMenuItem7.Click += toolStripMenuItem7_Click;
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(128, 26);
            toolStripMenuItem8.Text = "400%";
            toolStripMenuItem8.Click += toolStripMenuItem8_Click;
            // 
            // toolStripMenuItem9
            // 
            toolStripMenuItem9.Name = "toolStripMenuItem9";
            toolStripMenuItem9.Size = new Size(128, 26);
            toolStripMenuItem9.Text = "500%";
            toolStripMenuItem9.Click += toolStripMenuItem9_Click;
            // 
            // thumbnailViewToolStripMenuItem
            // 
            thumbnailViewToolStripMenuItem.Name = "thumbnailViewToolStripMenuItem";
            thumbnailViewToolStripMenuItem.Size = new Size(198, 26);
            thumbnailViewToolStripMenuItem.Text = "Thumbnail View";
            thumbnailViewToolStripMenuItem.Click += thumbnailViewToolStripMenuItem_Click;
            // 
            // colorFiltersToolStripMenuItem
            // 
            colorFiltersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { filterToolStripMenuItem, greyscaleToolStripMenuItem, sepiaToneToolStripMenuItem, invertToolStripMenuItem });
            colorFiltersToolStripMenuItem.Name = "colorFiltersToolStripMenuItem";
            colorFiltersToolStripMenuItem.Size = new Size(102, 24);
            colorFiltersToolStripMenuItem.Text = "Color Filters";
            // 
            // filterToolStripMenuItem
            // 
            filterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { redFilterToolStripMenuItem, greenFilterToolStripMenuItem, blueFilterToolStripMenuItem });
            filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            filterToolStripMenuItem.Size = new Size(165, 26);
            filterToolStripMenuItem.Text = "Filter";
            // 
            // redFilterToolStripMenuItem
            // 
            redFilterToolStripMenuItem.Name = "redFilterToolStripMenuItem";
            redFilterToolStripMenuItem.Size = new Size(168, 26);
            redFilterToolStripMenuItem.Text = "Red Filter";
            redFilterToolStripMenuItem.Click += redFilterToolStripMenuItem_Click;
            // 
            // greenFilterToolStripMenuItem
            // 
            greenFilterToolStripMenuItem.Name = "greenFilterToolStripMenuItem";
            greenFilterToolStripMenuItem.Size = new Size(168, 26);
            greenFilterToolStripMenuItem.Text = "Green Filter";
            greenFilterToolStripMenuItem.Click += greenFilterToolStripMenuItem_Click;
            // 
            // blueFilterToolStripMenuItem
            // 
            blueFilterToolStripMenuItem.Name = "blueFilterToolStripMenuItem";
            blueFilterToolStripMenuItem.Size = new Size(168, 26);
            blueFilterToolStripMenuItem.Text = "Blue Filter";
            blueFilterToolStripMenuItem.Click += blueFilterToolStripMenuItem_Click;
            // 
            // greyscaleToolStripMenuItem
            // 
            greyscaleToolStripMenuItem.Name = "greyscaleToolStripMenuItem";
            greyscaleToolStripMenuItem.Size = new Size(165, 26);
            greyscaleToolStripMenuItem.Text = "Greyscale";
            greyscaleToolStripMenuItem.Click += greyscaleToolStripMenuItem_Click;
            // 
            // sepiaToneToolStripMenuItem
            // 
            sepiaToneToolStripMenuItem.Name = "sepiaToneToolStripMenuItem";
            sepiaToneToolStripMenuItem.Size = new Size(165, 26);
            sepiaToneToolStripMenuItem.Text = "Sepia Tone";
            sepiaToneToolStripMenuItem.Click += sepiaToneToolStripMenuItem_Click;
            // 
            // invertToolStripMenuItem
            // 
            invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            invertToolStripMenuItem.Size = new Size(165, 26);
            invertToolStripMenuItem.Text = "Invert";
            invertToolStripMenuItem.Click += invertToolStripMenuItem_Click;
            // 
            // imageToolStripMenuItem
            // 
            imageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { resizeToolStripMenuItem, rotateAndFlipToolStripMenuItem, customRotateToolStripMenuItem });
            imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            imageToolStripMenuItem.Size = new Size(65, 24);
            imageToolStripMenuItem.Text = "Image";
            imageToolStripMenuItem.Click += imageToolStripMenuItem_Click;
            // 
            // resizeToolStripMenuItem
            // 
            resizeToolStripMenuItem.Name = "resizeToolStripMenuItem";
            resizeToolStripMenuItem.Size = new Size(193, 26);
            resizeToolStripMenuItem.Text = "Resize";
            resizeToolStripMenuItem.Click += resizeToolStripMenuItem_Click;
            // 
            // rotateAndFlipToolStripMenuItem
            // 
            rotateAndFlipToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { flipHorizontalToolStripMenuItem, flipVerticalToolStripMenuItem, rotate90DegreesToolStripMenuItem, rotate180DegreesToolStripMenuItem, rotate270DegreesToolStripMenuItem });
            rotateAndFlipToolStripMenuItem.Name = "rotateAndFlipToolStripMenuItem";
            rotateAndFlipToolStripMenuItem.Size = new Size(193, 26);
            rotateAndFlipToolStripMenuItem.Text = "Rotate and Flip";
            // 
            // flipHorizontalToolStripMenuItem
            // 
            flipHorizontalToolStripMenuItem.Name = "flipHorizontalToolStripMenuItem";
            flipHorizontalToolStripMenuItem.Size = new Size(221, 26);
            flipHorizontalToolStripMenuItem.Text = "Flip Horizontal";
            flipHorizontalToolStripMenuItem.Click += flipHorizontalToolStripMenuItem_Click;
            // 
            // flipVerticalToolStripMenuItem
            // 
            flipVerticalToolStripMenuItem.Name = "flipVerticalToolStripMenuItem";
            flipVerticalToolStripMenuItem.Size = new Size(221, 26);
            flipVerticalToolStripMenuItem.Text = "Flip Vertical";
            flipVerticalToolStripMenuItem.Click += flipVerticalToolStripMenuItem_Click;
            // 
            // rotate90DegreesToolStripMenuItem
            // 
            rotate90DegreesToolStripMenuItem.Name = "rotate90DegreesToolStripMenuItem";
            rotate90DegreesToolStripMenuItem.Size = new Size(221, 26);
            rotate90DegreesToolStripMenuItem.Text = "Rotate 90 degrees";
            rotate90DegreesToolStripMenuItem.Click += rotate90DegreesToolStripMenuItem_Click;
            // 
            // rotate180DegreesToolStripMenuItem
            // 
            rotate180DegreesToolStripMenuItem.Name = "rotate180DegreesToolStripMenuItem";
            rotate180DegreesToolStripMenuItem.Size = new Size(221, 26);
            rotate180DegreesToolStripMenuItem.Text = "Rotate 180 degrees";
            rotate180DegreesToolStripMenuItem.Click += rotate180DegreesToolStripMenuItem_Click;
            // 
            // rotate270DegreesToolStripMenuItem
            // 
            rotate270DegreesToolStripMenuItem.Name = "rotate270DegreesToolStripMenuItem";
            rotate270DegreesToolStripMenuItem.Size = new Size(221, 26);
            rotate270DegreesToolStripMenuItem.Text = "Rotate 270 degrees";
            rotate270DegreesToolStripMenuItem.Click += rotate270DegreesToolStripMenuItem_Click;
            // 
            // customRotateToolStripMenuItem
            // 
            customRotateToolStripMenuItem.Name = "customRotateToolStripMenuItem";
            customRotateToolStripMenuItem.Size = new Size(193, 26);
            customRotateToolStripMenuItem.Text = "Custom Rotate";
            customRotateToolStripMenuItem.Click += customRotateToolStripMenuItem_Click;
            // 
            // insertToolStripMenuItem
            // 
            insertToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { textToolStripMenuItem, imageToolStripMenuItem1 });
            insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            insertToolStripMenuItem.Size = new Size(59, 24);
            insertToolStripMenuItem.Text = "Insert";
            // 
            // textToolStripMenuItem
            // 
            textToolStripMenuItem.Name = "textToolStripMenuItem";
            textToolStripMenuItem.Size = new Size(134, 26);
            textToolStripMenuItem.Text = "Text";
            textToolStripMenuItem.Click += textToolStripMenuItem_Click_1;
            // 
            // imageToolStripMenuItem1
            // 
            imageToolStripMenuItem1.Name = "imageToolStripMenuItem1";
            imageToolStripMenuItem1.Size = new Size(134, 26);
            imageToolStripMenuItem1.Text = "Image";
            imageToolStripMenuItem1.Click += imageToolStripMenuItem1_Click;
            // 
            // twoImageToolStripMenuItem
            // 
            twoImageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { checkersToolStripMenuItem, mergeToolStripMenuItem });
            twoImageToolStripMenuItem.Name = "twoImageToolStripMenuItem";
            twoImageToolStripMenuItem.Size = new Size(96, 24);
            twoImageToolStripMenuItem.Text = "Two Image";
            // 
            // checkersToolStripMenuItem
            // 
            checkersToolStripMenuItem.Name = "checkersToolStripMenuItem";
            checkersToolStripMenuItem.Size = new Size(154, 26);
            checkersToolStripMenuItem.Text = "Checkers ";
            checkersToolStripMenuItem.Click += checkersToolStripMenuItem_Click;
            // 
            // mergeToolStripMenuItem
            // 
            mergeToolStripMenuItem.Name = "mergeToolStripMenuItem";
            mergeToolStripMenuItem.Size = new Size(154, 26);
            mergeToolStripMenuItem.Text = "Merge";
            mergeToolStripMenuItem.Click += mergeToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.BackColor = SystemColors.Info;
            pictureBox1.Location = new Point(0, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1861, 606);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // trackBar1
            // 
            trackBar1.Anchor = AnchorStyles.Bottom;
            trackBar1.Location = new Point(83, 680);
            trackBar1.Maximum = 100;
            trackBar1.Minimum = -100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(1686, 56);
            trackBar1.TabIndex = 2;
            trackBar1.Scroll += trackBar1_Scroll_1;
            // 
            // trackBar2
            // 
            trackBar2.Anchor = AnchorStyles.Bottom;
            trackBar2.Location = new Point(79, 825);
            trackBar2.Maximum = 0;
            trackBar2.Minimum = -100;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(1690, 56);
            trackBar2.TabIndex = 3;
            trackBar2.Scroll += trackBar2_Scroll_1;
            // 
            // trackBar3
            // 
            trackBar3.Anchor = AnchorStyles.Bottom;
            trackBar3.Location = new Point(79, 742);
            trackBar3.Maximum = 255;
            trackBar3.Minimum = -255;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(1690, 56);
            trackBar3.TabIndex = 4;
            trackBar3.Scroll += trackBar3_Scroll;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(0, 680);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 5;
            label1.Text = "Brightness";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(0, 756);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 6;
            label2.Text = "Contrast";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Location = new Point(0, 847);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 7;
            label3.Text = "Alpha";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1781, 965);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(trackBar3);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Processing ";
            Load += Form1_Load;
            Paint += Form1_Paint;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem colorFiltersToolStripMenuItem;
        private ToolStripMenuItem imageToolStripMenuItem;
        private ToolStripMenuItem insertToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem clearImageToolStripMenuItem;
        private ToolStripMenuItem zoomToolStripMenuItem;
        private ToolStripMenuItem thumbnailViewToolStripMenuItem;
        private ToolStripMenuItem filterToolStripMenuItem;
        private ToolStripMenuItem redFilterToolStripMenuItem;
        private ToolStripMenuItem greenFilterToolStripMenuItem;
        private ToolStripMenuItem blueFilterToolStripMenuItem;
        private ToolStripMenuItem greyscaleToolStripMenuItem;
        private ToolStripMenuItem sepiaToneToolStripMenuItem;
        private ToolStripMenuItem invertToolStripMenuItem;
        private ToolStripMenuItem resizeToolStripMenuItem;
        private ToolStripMenuItem rotateAndFlipToolStripMenuItem;
        private ToolStripMenuItem flipHorizontalToolStripMenuItem;
        private ToolStripMenuItem flipVerticalToolStripMenuItem;
        private ToolStripMenuItem rotate90DegreesToolStripMenuItem;
        private ToolStripMenuItem rotate180DegreesToolStripMenuItem;
        private ToolStripMenuItem rotate270DegreesToolStripMenuItem;
        private ToolStripMenuItem textToolStripMenuItem;
        private ToolStripMenuItem imageToolStripMenuItem1;
        public PictureBox pictureBox1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem customRotateToolStripMenuItem;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private TrackBar trackBar3;
        private Label label1;
        private Label label2;
        private Label label3;
        private ToolStripMenuItem twoImageToolStripMenuItem;
        private ToolStripMenuItem checkersToolStripMenuItem;
        private ToolStripMenuItem mergeToolStripMenuItem;
    }
}
