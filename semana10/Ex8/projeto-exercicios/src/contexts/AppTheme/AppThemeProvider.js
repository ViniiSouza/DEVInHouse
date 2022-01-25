import { useState } from "react"
import { AppThemeContext } from "./AppThemeContext";

export const dark={
    corPrincipal: '#02176d',
    corSecundaria: '#efefef'
}
export const light={
    corPrincipal: '#efefef',
    corSecundaria: '#02176d'
}

export const AppThemeProvider = ({ children }) => {
    const [theme, setTheme] = useState('light');
    const themeColors = theme === 'light' ? light : dark;

    return <AppThemeContext.Provider value={{ theme: theme, setTheme: setTheme, themeColors: themeColors }}>{children}</AppThemeContext.Provider>
}