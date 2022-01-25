import { useState } from "react";
import { LoggedUsersContext } from "./LoggedUsersContext";

export const LoggedUsersProvider = ({ children }) => {
    const [user, setUser] = useState({ autenticado: true, nome: 'Vinícius' });
    return <LoggedUsersContext.Provider value={{ user, setUser }}>
        {children}
    </LoggedUsersContext.Provider>
}