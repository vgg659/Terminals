﻿using System;
using System.Xml;
using Terminals.Connections;

namespace Terminals.Integration.Export
{
    internal class TerminalsRdpExport
    {
        public static void ExportRdpOptions(XmlTextWriter w, FavoriteConfigurationElement favorite)
        {
            if (favorite.Protocol == ConnectionManager.RDP)
            {
                ExportRdpDesktopOptions(w, favorite);
                ExportRdpUiOptions(w, favorite);
                ExporRdpLocalResources(w, favorite);
                ExportRdpExtendedOptions(w, favorite);
                ExportRdpTimeoutOptions(w, favorite);
                ExportRdpSecurityOptions(w, favorite);
                ExportRdpTsgwOptions(w, favorite);
            }
        }

        private static void ExportRdpDesktopOptions(XmlTextWriter w, FavoriteConfigurationElement favorite)
        {
            w.WriteElementString("desktopSize", favorite.DesktopSize.ToString());
            w.WriteElementString("desktopSizeHeight", favorite.DesktopSizeHeight.ToString());
            w.WriteElementString("desktopSizeWidth", favorite.DesktopSizeWidth.ToString());
            w.WriteElementString("colors", favorite.Colors.ToString());
        }

        private static void ExportRdpUiOptions(XmlTextWriter w, FavoriteConfigurationElement favorite)
        {
            if (favorite.DisableCursorShadow)
                w.WriteElementString("disableCursorShadow", favorite.DisableCursorShadow.ToString());
            if (favorite.DisableCursorBlinking)
                w.WriteElementString("disableCursorBlinking", favorite.DisableCursorBlinking.ToString());
            if (favorite.DisableFullWindowDrag)
                w.WriteElementString("disableFullWindowDrag", favorite.DisableFullWindowDrag.ToString());
            if (favorite.DisableMenuAnimations)
                w.WriteElementString("disableMenuAnimations", favorite.DisableMenuAnimations.ToString());
            if (favorite.DisableTheming)
                w.WriteElementString("disableTheming", favorite.DisableTheming.ToString());
            if (favorite.DisableWallPaper)
                w.WriteElementString("disableWallPaper", favorite.DisableWallPaper.ToString());
            if (favorite.EnableFontSmoothing)
                w.WriteElementString("enableFontSmoothing", favorite.EnableFontSmoothing.ToString());
            if (favorite.EnableDesktopComposition)
                w.WriteElementString("enableDesktopComposition", favorite.EnableDesktopComposition.ToString());
            if (favorite.ConnectToConsole)
                w.WriteElementString("connectToConsole", favorite.ConnectToConsole.ToString());
        }

        private static void ExporRdpLocalResources(XmlTextWriter w, FavoriteConfigurationElement favorite)
        {
            w.WriteElementString("sounds", favorite.Sounds.ToString());
            if (!String.IsNullOrEmpty(favorite.redirectedDrives))
                w.WriteElementString("redirectedDrives", favorite.redirectedDrives);
            if (favorite.RedirectPorts)
                w.WriteElementString("redirectPorts", favorite.RedirectPorts.ToString());
            if (favorite.RedirectPrinters)
                w.WriteElementString("redirectPrinters", favorite.RedirectPrinters.ToString());
            if (favorite.RedirectSmartCards)
                w.WriteElementString("redirectSmartCards", favorite.RedirectSmartCards.ToString());
            if (favorite.RedirectClipboard)
                w.WriteElementString("redirectClipboard", favorite.RedirectClipboard.ToString());
            if (favorite.RedirectDevices)
                w.WriteElementString("redirectDevices", favorite.RedirectDevices.ToString());
            if (!String.IsNullOrEmpty(favorite.DesktopShare))
                w.WriteElementString("desktopShare", favorite.DesktopShare);
        }

        private static void ExportRdpExtendedOptions(XmlTextWriter w, FavoriteConfigurationElement favorite)
        {
            if (favorite.AllowBackgroundInput)
                w.WriteElementString("allowBackgroundInput", favorite.AllowBackgroundInput.ToString());
            if (favorite.GrabFocusOnConnect)
                w.WriteElementString("grabFocusOnConnect", favorite.GrabFocusOnConnect.ToString());
            if (favorite.AcceleratorPassthrough)
                w.WriteElementString("acceleratorPassthrough", favorite.AcceleratorPassthrough.ToString());
            if (favorite.DisableControlAltDelete)
                w.WriteElementString("disableControlAltDelete", favorite.DisableControlAltDelete.ToString());
            if (favorite.DisplayConnectionBar)
                w.WriteElementString("displayConnectionBar", favorite.DisplayConnectionBar.ToString());
            if (favorite.DoubleClickDetect)
                w.WriteElementString("doubleClickDetect", favorite.DoubleClickDetect.ToString());
            if (favorite.DisableWindowsKey)
                w.WriteElementString("disableWindowsKey", favorite.DisableWindowsKey.ToString());

            if (favorite.EnableEncryption)
                w.WriteElementString("enableEncryption", favorite.EnableEncryption.ToString());
            if (favorite.EnableCompression)
                w.WriteElementString("enableCompression", favorite.EnableCompression.ToString());
            if (favorite.EnableTLSAuthentication)
                w.WriteElementString("enableTLSAuthentication", favorite.EnableTLSAuthentication.ToString());
            if (favorite.EnableNLAAuthentication)
                w.WriteElementString("enableNLAAuthentication", favorite.EnableNLAAuthentication.ToString());
        }

        private static void ExportRdpTimeoutOptions(XmlTextWriter w, FavoriteConfigurationElement favorite)
        {
            w.WriteElementString("idleTimeout", favorite.IdleTimeout.ToString());
            w.WriteElementString("overallTimeout", favorite.OverallTimeout.ToString());
            w.WriteElementString("connectionTimeout", favorite.ConnectionTimeout.ToString());
            w.WriteElementString("shutdownTimeout", favorite.ShutdownTimeout.ToString());
        }

        private static void ExportRdpSecurityOptions(XmlTextWriter w, FavoriteConfigurationElement favorite)
        {
            if (favorite.EnableSecuritySettings)
            {
                w.WriteElementString("enableSecuritySettings", favorite.EnableSecuritySettings.ToString());
                w.WriteElementString("securityStartProgram", favorite.SecurityStartProgram);
                w.WriteElementString("securityWorkingFolder", favorite.SecurityWorkingFolder);
                w.WriteElementString("securityFullScreen", favorite.SecurityFullScreen.ToString());
            }
        }

        private static void ExportRdpTsgwOptions(XmlTextWriter w, FavoriteConfigurationElement favorite)
        {
            if (favorite.TsgwUsageMethod != 0)
            {
                w.WriteElementString("tsgwUsageMethod", favorite.TsgwUsageMethod.ToString());
                w.WriteElementString("tsgwCredsSource", favorite.TsgwCredsSource.ToString());
                w.WriteElementString("tsgwDomain", favorite.TsgwDomain);
                w.WriteElementString("tsgwHostname", favorite.TsgwHostname);
                w.WriteElementString("tsgwPassword", favorite.TsgwPassword);
                w.WriteElementString("tsgwSeparateLogin", favorite.TsgwSeparateLogin.ToString());
                w.WriteElementString("tsgwUsername", favorite.TsgwUsername);
            }
        }
    }
}