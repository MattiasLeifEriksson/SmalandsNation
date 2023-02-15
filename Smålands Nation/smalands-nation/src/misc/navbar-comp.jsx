
import { Link, BrowserRouter } from "react-router-dom"
import "./navbar.css"

import React from "react";
const Navbar = () => {

    return (
        <div id="navbar-container" className=" " >
           
           
            <ul id="navbar-list">
                <li className="navbar-items">
                <Link to="/"><img id="logo" src={require("../images/SmalandsLogo.gif")} alt="image not found" /></Link>
                </li>
                <li className="navbar-items">
                <Link to="/">Start</Link>
                </li>
                <li className="navbar-items" >
                <Link to="/about">Bakgrund</Link>
                </li>
                <li className="navbar-items">
                <Link to="/board">Styrelse</Link>
                </li>
                <li className="navbar-items">
                <Link to="/archive">Arkiv</Link>
                </li>
                <li className="navbar-items">
                <Link to="/work">Jobba</Link>
                </li>
                
            </ul>
            
        </div>
    )
}
export default Navbar