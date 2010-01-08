﻿namespace Tvl.VisualStudio.Tools.AstExplorer
{
    using System.Windows;
    using System.Windows.Media.Imaging;
    using Tvl.VisualStudio.Shell;

    internal class AstExplorerWindow : IToolWindow
    {
        private AstExplorerProvider _provider;

        public AstExplorerWindow(AstExplorerProvider provider)
        {
            this._provider = provider;
        }

        public string Caption
        {
            get
            {
                return "AST Explorer";
            }
        }

        public BitmapSource Icon
        {
            get
            {
                return null;
            }
        }

        public FrameworkElement CreateContent()
        {
            return new AstExplorerControl(this._provider);
        }
    }
}
