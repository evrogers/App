using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace App
{
    public class DropDownMenu: ContextMenuStrip
    {
        private bool isMainMenu;
        private int menuItemHeight = 20;
        private Color menuItemTextColor = Color.Empty;
        private Color primaryColor = Color.Empty;
        private Bitmap menuItemHeaderSize;

        public DropDownMenu(IContainer container)
            : base(container)
        {
        }
       
        [Browsable(false)]
        public bool IsMainMenu
        {
            get { return isMainMenu; }
            set { isMainMenu = value; }
        }
        [Browsable(false)]
        public int MenuItemHeight
        {
            get { return menuItemHeight; }
            set { menuItemHeight = value; }
        }
        [Browsable(false)]
        public Color MenuItemTextColor
        {
            get { return menuItemTextColor; }
            set { menuItemTextColor = value; }
        }
        [Browsable(false)]
        public Color PrimaryColor
        {
            get { return primaryColor; }
            set { primaryColor = value; }
        }

        private void LoadMenuItemHeight()
        {
            Size resolution = Screen.PrimaryScreen.Bounds.Size;

            if (resolution.Width < 1920 && resolution.Height < 1080)
            {
                if (isMainMenu)
                    menuItemHeaderSize = new Bitmap(20, 20);
                else menuItemHeaderSize = new Bitmap(20, menuItemHeight);
                foreach (ToolStripMenuItem menuItemL1 in this.Items.OfType<ToolStripMenuItem>())
                {
                    menuItemL1.ImageScaling = ToolStripItemImageScaling.None;
                    if (menuItemL1.Image == null) menuItemL1.Image = menuItemHeaderSize;
                }
            }
            else
            {
                if (isMainMenu)
                    menuItemHeaderSize = new Bitmap(20, 30);
                else menuItemHeaderSize = new Bitmap(20, menuItemHeight);
                foreach (ToolStripMenuItem menuItemL1 in this.Items.OfType<ToolStripMenuItem>())
                {
                    menuItemL1.ImageScaling = ToolStripItemImageScaling.None;
                    if (menuItemL1.Image == null) menuItemL1.Image = menuItemHeaderSize;
                }
            }
            
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (this.DesignMode == false)
            {
                this.Renderer = new MenuRenderer(isMainMenu, primaryColor, menuItemTextColor);
                LoadMenuItemHeight();
            }
        }
    }
}
