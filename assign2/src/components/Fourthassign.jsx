import React,{  useState } from 'react'
import { Rating } from 'react-simple-star-rating'


function Product(link,color){

    const [rating, setRating] = useState(0) // initial rating value
  
  
    const handleRating = (rate) => {
      setRating(rate)
    
    }

    return(
        <div className='body-Border'>
        <div className='bodyRating'>
<div class="flex-container">
<div >
    <img  src={link}/>
    <div >
    <h1 className='product-Name'>Apple iPhone 12 (64GB) - {color}</h1> 
    </div>  
</div>
<div className='tableMargine'>
<table className="table">
<tr>
    <th table-head-spacing>Display:</th>
    <td>6.1-inch (15.5 cm diagonal) Super Retina XDR display with True Tone</td>
</tr>
<tr>
    <th table-head-spacing>Capacity:</th>
    <td>4GB,128GB,256GB</td>
</tr>
<tr>
    <th table-head-spacing>Splash, Water, and Dust Resistant:</th>
    <td>All-glass and surgical-grade stainless steel design, water and dust resistant (rated IP68)</td>
</tr>
<tr>
    <th table-head-spacing>Camera and Video:</th>
    <td>Dual 12MP cameras with Portrait mode, Depth Control, Portrait Lighting, Smart HDR, and 4K Dolby Vision HDR video up to 60 fps</td>
</tr>
<tr>
    <th table-head-spacing>Front Camera:</th>
    <td>12MP TrueDepth front camera with Portrait mode, Depth Control, Portrait Lighting, and Smart HDR 3</td>
</tr>
<tr>
    <th table-head-spacing>Power and Battery:</th>
    <td>Video playback:Up to 17 hours, Video playback (streamed):Up to 11 hours, Audio playback:Up to 65 hours, 20W adapter or higher (sold separately), Fast-charge capable: Up to 50% charge in around 30 minutes with 20W adapter or higher</td>
</tr>
<tr>
    <th table-head-spacing>In the Box:</th>
    <td>iPhone with iOS 14, USB-C to Lightning Cable, Documentation</td>
</tr>
</table>

<table class="table">
<tr>
    <th className='table-head-spacing'>About this item:</th>
    <td>
        <ul>
            <li>6.1-inch (15.5 cm diagonal) Super Retina XDR display</li>
            <li>Ceramic Shield, tougher than any smartphone glass</li>
            <li>A14 Bionic chip, the fastest chip ever in a smartphone</li>
            <li>Advanced dual-camera system with 12MP Ultra Wide and Wide cameras; Night mode, Deep Fusion, Smart HDR 3, 4K Dolby Vision HDR recording</li>
            <li>12MP TrueDepth front camera with Night mode, 4K Dolby Vision HDR recording</li>
            <li>Supports MagSafe accessories for easy attachment and faster wireless charging</li>
            <li>iOS with redesigned widgets on the Home screen, all-new App Library, App Clips and more</li>
        </ul>
    </td>
</tr>
</table>
<div>
    <h1>Give Rating</h1>

    <div className='App'>
        <Rating onClick={handleRating} ratingValue={rating}/>
      </div>
{/* 
      //npm i react-simple-star-rating */}

 </div>
</div>
</div>
</div>
</div>
    )
}

const Fourthassign = () => {
      const product1Link="https://m.media-amazon.com/images/I/71hIfcIPyxS._SX679_.jpg"
      const product2Link="https://m.media-amazon.com/images/I/71cQWYVtcBL._SX679_.jpg"
      const product3Link="https://m.media-amazon.com/images/I/71E5zB1qbIL._SX679_.jpg"
      const product4Link="https://m.media-amazon.com/images/I/711wsjBtWeL._SX679_.jpg"

    
  return (
    <div>
        <h1 className='headingRating'>Products Which You Bought</h1>
{Product(product1Link,'BLUE')}
{Product(product2Link,'GREEN')}
{Product(product3Link,'RED')}
{Product(product4Link,'WHITE')}
</div>
  )
}

export default Fourthassign