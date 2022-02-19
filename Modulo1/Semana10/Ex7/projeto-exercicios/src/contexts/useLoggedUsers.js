import { useContext } from "react";
import { LoggedUsersContext } from "./LoggedUsersContext";

export const useLoggedUsers = () => useContext(LoggedUsersContext);