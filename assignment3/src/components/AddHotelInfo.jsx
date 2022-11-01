import React,{useState} from 'react'
import { useNavigate } from 'react-router';
import NavBar from './NavBar';

const AddHotelInfo = (props) => {
const navigate=useNavigate("/AddHotelInfo")
const[id,setId]=useState();
const[title,setTitle]=useState();
const[hotelName,setHotelName]=useState();
const[img,setImg]=useState();
const[array,setArray]=useState([...props.hotelInfo]);
const ObjectAddToArray=()=>{
const object1={id:id,hotelName:hotelName,title:title,img:img}
  //  array=[...array,object1]

  }

    return (
  <div>
  <div className='registerBackground' >
      <NavBar/>        
  <div className='hotelHeading'>
  <span>  
  <h1> <b> <i> HOTEL.COM</i></b></h1>
  </span>
  </div>
  <br />
  <h2>ENTER HOTEL DETAILS: <hr /> </h2>
  <div class="flex-container">
  <div>Enter Hotel Id:
  <input type="text" onChange={(e)=>setId(e.target.value)} />
  </div>
  <div>Hotel Name:  <input type="text" onChange={(e)=>setHotelName(e.target.value)}/></div>
  </div>
  <div class="flex-container">  
  <div>Enter Discription: <input type="text" onChange={(e)=>setTitle(e.target.value)} /></div>
  <div>Enter Image Link:
  <input type="text" onChange={(e)=>setImg(e.target.value)}/>
  </div>
  </div>
  <div className="hotelInfoEnter">
  <div class="d-grid gap-2 col-6 mx-auto">  
  <button onClick={ObjectAddToArray}    class="btn btn-primary" type="button">Enter</button>
</div>
</div> 
</div>
</div>
      )
  
}

export default AddHotelInfo
