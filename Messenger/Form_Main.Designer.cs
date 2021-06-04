namespace Messenger
{
    partial class Form_Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.webBrowser_Main = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowser_Main
            // 
            this.webBrowser_Main.AllowWebBrowserDrop = false;
            this.webBrowser_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser_Main.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser_Main.Location = new System.Drawing.Point(0, 0);
            this.webBrowser_Main.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_Main.Name = "webBrowser_Main";
            this.webBrowser_Main.ScriptErrorsSuppressed = true;
            this.webBrowser_Main.ScrollBarsEnabled = false;
            this.webBrowser_Main.Size = new System.Drawing.Size(624, 442);
            this.webBrowser_Main.TabIndex = 0;
            this.webBrowser_Main.Url = new System.Uri("https://www.messenger.com", System.UriKind.Absolute);
            this.webBrowser_Main.WebBrowserShortcutsEnabled = false;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.webBrowser_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Messenger";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser_Main;
    }
}

