import React from "react";
import { getImages } from "../API/imageAPI";
import { useEffect, useState } from "react";
const Archive = () => {
    const [fullscreen, setFullscreen] = useState(false);
    const [currentImage, setCurrentImage] = useState(null);
    const [imageArray, setImageArray] = useState([]);
 

    useEffect(() => {
      if (imageArray.length === 0) {
        getImages().then((result) => setImageArray(result));
      }
  
    }, [imageArray]);
   console.log(imageArray);
   const handleImageClick = (image) => {
    setFullscreen(true);
    setCurrentImage(image);
};
    return(
        <div className="row">
    <h1>Image archive</h1>
        
        <div className="archive">

        {imageArray.map((object, i) => (

 <div className="ArchiveImage">
     <img  key={i} src={"https://i.imgur.com/qDYWGd1.jpeg"} onClick={() => handleImageClick(object)} alt="archive"></img>
     <label key={i + " Title"} className="imageText" >Titel: {object.title}</label>

     <label key={i + " Desc"} className="imageText" >Description: {object.description}</label>
     

 </div>


))}
</div>
{fullscreen && (
                <div className="fullscreen-overlay">
                    <img src={"https://i.imgur.com/qDYWGd1.jpeg"} onClick={() => setFullscreen(false)} alt="fullscreen"></img>
                    <label className="fullscreen-text">Titel: {currentImage.title}</label>
                    <label className="fullscreen-text">Post: {currentImage.description}</label>
                    
                </div>
            )}
        </div>
    )
}
export default Archive;