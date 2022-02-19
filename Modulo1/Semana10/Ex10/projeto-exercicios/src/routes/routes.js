import { Home } from "../components/Home/Home";
import { Routes, Route } from 'react-router-dom';
import { Contatos } from "../components/Contatos/Contatos";

export const Router = () => (
    <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/contatos" element={<Contatos />} />
        <Route path="*" element={<Home />} />
    </Routes>
);