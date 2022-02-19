import { useAppTheme } from "../../contexts/AppTheme";

export const Layout = ({children}) => {
    const { theme, themeColors } = useAppTheme();

    return(
        <div style={{ backgroundColor: themeColors.corPrincipal, color: themeColors.corSecundaria }}>{children}</div>
    )
}
