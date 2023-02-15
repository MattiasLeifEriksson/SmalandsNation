import axios from "axios";
// Get All Posts
export const getBoard = async () => {
    
    const boardURL = `https://localhost:7053/api/Boards `;
    var board;
    await axios.get(boardURL)
    .then(res => board = res.data)
    return board
}