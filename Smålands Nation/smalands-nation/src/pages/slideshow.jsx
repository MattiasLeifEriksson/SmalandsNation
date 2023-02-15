import React, { useState, useEffect } from "react";
import { getImages } from "../API/imageAPI";
import "./slideshow.css";
export default function Slideshow( ) {
    let images = ["./logo512.png", "./eef.png"];
    const [imageArray, setImageArray] = useState([]);
  // Set the initial state for the current image index
  const [currentImageIndex, setCurrentImageIndex] = useState(0);

  useEffect(() => {
    if (imageArray.length === 0) {
      getImages().then((result) => setImageArray(result));
    }

  }, [imageArray]);
 console.log(imageArray);
  // Create a function to handle advancing the slideshow to the next image
  const nextImage = () => {
    setCurrentImageIndex(currentImageIndex + 1);

    // If we are at the last image, go back to the first image
    if (currentImageIndex === images.length - 1) {
      setCurrentImageIndex(0);
    }
  };

  // Create a function to handle going back to the previous image
  const prevImage = () => {
    setCurrentImageIndex(currentImageIndex - 1);

    // If we are at the first image, go to the last image
    if (currentImageIndex === 0) {
      setCurrentImageIndex(images.length - 1);
    }
  };

  

  return (
    <div className="slideshowWrapper">
      {/* Render the current image */}
      <img className="slideShowImage" src={images[currentImageIndex]} alt="Slideshow" />

      {/* Render buttons to navigate the slideshow */}
      <button onClick={prevImage}>&lt;</button>
      <button onClick={nextImage}>&gt;</button>
    </div>
  );
}
