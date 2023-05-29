import { BrowserRouter, NavLink, Route, Routes } from 'react-router-dom';
import './App.css';
import { WebshopList } from './webshopList';
import { WebshopSinglePage } from './webshopSinglePage.js';
import {WebshopCreatePage} from './webshopCreatePage.js';

function App() {
  return (
    <BrowserRouter>
    <nav className="navbar navbar-expand-sm navbar-dark bg-dark">
      <div className="collapse navbar-collapse" id="navbarNav">
        <ul className="navbar-nav">
          <li className="nav-item">
            <NavLink to={`/`} className={({ isActive }) => "nav-link" + (isActive ? " active" : "")} end>
              <span className="nav-link">Típusok</span>
            </NavLink>
          </li>
          <li className="nav-item">
            <NavLink to={`/uj-tip`} className={({ isActive }) => "nav-link" + (isActive ? " active" : "")}>
              <span className="nav-link">Új típusok</span>
            </NavLink>
          </li>
        </ul>
      </div>
    </nav>
    <Routes>
        <Route path="/" element={<WebshopList />} />
        <Route path="/Tipusok/:tipusId" element={<WebshopSinglePage />} />
        <Route path="/uj-tip" element={<WebshopCreatePage />} />
    </Routes>
    </BrowserRouter>
  );
}

export default App;