import React from "react";
import Slideshow from "./slideshow";

const StartUp = () => {
return (
<div className="startup-container">
<header className="header">
<h1>Välkommen till Smålands Nation</h1>
<p>
Musiknationen på Växjö Campus, där fest och levande musik står högst
på dagsordningen
</p>
</header>
<Slideshow />
<br></br>
<div className="map-container">
<p>Här finns vi</p>
<iframe className="mapOfSmalands"
      src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2181.678685228886!2d14.82291101597351!3d56.8514551808615!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x465721628b07dd69%3A0xb5cea7d2e6129709!2sSm%C3%A5lands%20Nation!5e0!3m2!1sen!2sse!4v1675177675417!5m2!1sen!2sse" 
     width={914}
     height={500}
     style={{ border: "none" }}
       title="Smålands Nation Map"
     ></iframe>
</div>
</div>
);
};

export default StartUp;