import axios from "axios";

export const getImages = async () => {
    
    const imageURL = `https://localhost:7053/api/Images `;
    var images;
    await axios.get(imageURL)
    .then(res => images = res.data)
    return images
}