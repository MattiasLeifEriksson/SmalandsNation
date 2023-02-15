import React from "react";
import "./pages.css";
import { getBoard } from "../API/boardAPI";
import { useEffect, useState } from "react";

const Board = () => {
  const [boardArray, setBoardArray] = useState([]);
 

  useEffect(() => {
    if (boardArray.length === 0) {
      getBoard().then((result) => setBoardArray(result));
    }

  }, [boardArray]);
 console.log(boardArray);
  
  return (
    <div className="row">
      <h1>Nuvarande styrelse</h1>
      <div className="imageColumn">
     {boardArray.map((object, i) => (
 
        <div className="BoardImage">
            <img  key={i + "picture"} src={"https://i.imgur.com/qDYWGd1.jpeg"} alt="image"></img>
            <label key={i + "Name"} className="imageText" >Namn: {object.name}</label>
            <label key={i + "Role"} className="imageText" >Post: {object.role}</label>
            

        </div>
       
     
     ))}</div>
    </div>
  );
};
export default Board;
