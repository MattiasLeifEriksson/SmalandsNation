import { BrowserRouter, Routes, Route } from "react-router-dom";
import Navbar from "./misc/navbar-comp";
import React from "react";
import "./App.css";
import AboutUs from "./pages/about-us";
import StartUp from "./pages/startup-page";
import Board from "./pages/board-page";
import Archive from "./pages/archive";
import Work from "./pages/work";
import { SocialIcon } from 'react-social-icons';


function App() {
  return (
    <BrowserRouter>
      <div className="App">
        
        <div className="navbar">
          <Navbar />
        </div>

        <div className="App text-wrap">
          <div className="mb-5 mt-5 pb-5 pt-5">
            <Routes>
              <Route path="/" element={<StartUp />} />
              <Route path="/about" element={<AboutUs />} />
              <Route path="/board" element={<Board />} />
              <Route path="/archive" element={<Archive />} />
              <Route path="/work" element={<Work />} />
            </Routes>
          </div>
        </div>
      </div>
      <span id="footerSpan">
        <footer>
          <div id="footer-info">
             <p>Adress: Stallvägen 5, 352 52 Växjö </p>
              <p>Epost: ordf.smalands@gmail.com</p>
          </div>
         
          <div id="link-list">
          <p><SocialIcon id="hitract-logo" target="_blank" url="https://hitract.se/downloadApp/hitClub/172" /> </p>
          <p><SocialIcon id="insta-logo" target="_blank" url="https://www.instagram.com/smalandsnationvaxjo/?hl=en" /> </p>
          <p ><SocialIcon id="fb-logo" target="_blank" url="https://www.facebook.com/smalandsnation/" /> </p>
          </div>
        </footer>
      </span>
    </BrowserRouter>
  );
}

export default App;
