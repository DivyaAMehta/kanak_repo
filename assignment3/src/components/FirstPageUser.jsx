import React,{useState} from 'react'
import { useNavigate } from 'react-router';


const FirstPageUser = (props) => {
const navigate=useNavigate('/FirstPageUser')
const[bookingArray,setBookingArray]=useState([]);
const[title,setTitle]=useState();
const[hotelName,setHotelName]=useState();
const[img,setImg]=useState();
const[hotelInfoUpdate,setHotelInfoUpdate]=useState([...props.hotelInfo]);
const[counter,setCounter]=useState(3);

const ObjectAddToArray=()=>{
  const object1={id:counter,hotelName:hotelName,title:title,img:img}
  setHotelInfoUpdate([...hotelInfoUpdate,object1]);
  setCounter(counter+1)
}

  
  
  return (

<div>
  <div className='hotelHeadingUser'>
    <span>
      <h1> <b> <i> HOTEL.COM</i></b></h1>
    </span>
  </div>
    {hotelInfoUpdate.map((vals)=>{
      return(
      <div>
<div class="container my-4">
<hr class="my-4"/>
<div id="multi-item-example" class="carousel slide carousel-multi-item" data-ride="carousel">
<div class="carousel-inner" role="listbox">
<div class="carousel-item active">
  <div class="row">
    <div class="col-md-4">
      <div class="card mb-2">
        <img class="card-img-top" src={vals.img}
          alt="Card image cap"/>
        <div class="card-body">
          <h4 class="card-title">{vals.hotelName}</h4>
          <h4 class="card-title">ID:{vals.id}</h4>
          <p class="card-text">{vals.title}</p>
          <button onClick={()=>navigate('/BookTable')}  class="btn btn-outline-warning">Book Table</button>
        </div>
      </div>
    </div>
  </div>
  </div>  
  </div>
</div>
</div>
</div>
        )
      })}

     </div>
  )
}

export default FirstPageUser