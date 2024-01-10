/* This file is automatically generated by "gen_configs.py" */
import type { SiteLocaleData  } from '@vuepress/shared'
import type { DefaultThemeLocaleData } from '@vuepress/theme-default'
import { headConfig } from '../head.js'

const Translation = require('../../translations/ca.json')

export const mainConfig_ca: SiteLocaleData  = {
    lang: 'ca',
    title: Translation.title,
    description: Translation.description,
    head: headConfig
}

export const defaultThemeConfig_ca: DefaultThemeLocaleData = {
    selectLanguageName: "Català",
    selectLanguageText: Translation.theme.selectLanguageText,
    selectLanguageAriaLabel: Translation.theme.selectLanguageAriaLabel,

    navbar: [
        {
            text: Translation.navbar.AboutAndFeatures,
            link: "/l10n/ca/guide/",
            activeMatch: "/l10n/ca/index.html",
        },
        
        {
            text: Translation.navbar.Installation,
            link: "/l10n/ca/guide/installation.md",
            activeMatch: "/l10n/ca/guide/installation.html",
        },
      
        {
            text: Translation.navbar.Usage,
            link: "/l10n/ca/guide/usage.md",
            activeMatch: "/l10n/ca/guide/usage.html",
        },
      
        {
            text: Translation.navbar.Configuration,
            link: "/l10n/ca/guide/configuration.md",
            activeMatch: "/l10n/ca/guide/configuration.html",
        },
      
        {
            text: Translation.navbar.ChatBots,
            link: "/l10n/ca/guide/chat-bots.md",
            activeMatch: "/l10n/ca/guide/chat-bots.html",
        },
      
        {
            text: Translation.helpUsTranslate,
            link: "https://crwd.in/minecraft-console-client",
        },
    ],

    sidebar: [
        "/l10n/ca/guide/README.md", 
        "/l10n/ca/guide/installation.md", 
        "/l10n/ca/guide/usage.md", 
        "/l10n/ca/guide/configuration.md", 
        "/l10n/ca/guide/creating-text-script.md",
        "/l10n/ca/guide/chat-bots.md", 
        "/l10n/ca/guide/creating-bots.md", 
        "/l10n/ca/guide/contibuting.md"
    ],

    // page meta
    editLinkText: Translation.theme.editLinkText,
    lastUpdatedText: Translation.theme.lastUpdatedText,
    contributorsText: Translation.theme.contributorsText,

    // custom containers
    tip: Translation.theme.tip,
    warning: Translation.theme.warning,
    danger: Translation.theme.danger,

    // 404 page
    notFound: Translation.theme.notFound,
    backToHome: Translation.theme.backToHome,

    // a11y
    openInNewWindow: Translation.theme.openInNewWindow,
    toggleColorMode: Translation.theme.toggleColorMode,
    toggleSidebar: Translation.theme.toggleSidebar,
}
