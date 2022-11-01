import React,{useState} from 'react'
import AddHotelInfo from './AddHotelInfo';
import { useNavigate } from 'react-router';
import NavBar from './NavBar';


export const FirstPage = (props) => {
  const navigate=useNavigate('/FirstPage')
  const[id,setId]=useState();
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

const EditInformationFunction=()=>{
 const hId= prompt('enter hotel id');
 hotelInfoUpdate[hId-1].title=prompt('enter hotel Details');
 console.log(hotelInfoUpdate[hId-1].title);
}

const BookingOfTable=()=>{
 const hotelBookId=prompt('enter hotel Id FOr booking')
 setBookingArray([...bookingArray,`Table of ${hotelInfoUpdate[hotelBookId-1].hotelName} is Booked`])
}

const   CancelBookingOfTable=()=>{
  const hotelBookId=prompt('enter hotel Id FOr Cancelling')
  setBookingArray([...bookingArray,`Table of Hotel ${hotelInfoUpdate[hotelBookId-1].hotelName} is CancElled`])
 }
  
  
  return (

    <div>
  <NavBar/>
      <div className='hotelHeading'>
        <span>
          <h1> <b> <i> HOTEL.COM</i></b></h1>
        </span>
      </div>



      {/* <div>
    <div class="container my-4">
<hr class="my-4"/>

<div id="multi-item-example" class="carousel slide carousel-multi-item" data-ride="carousel">


<div class="carousel-inner" role="listbox">

<div class="carousel-item active">

  <div class="row">
    <div class="col-md-4">
      <div class="card mb-2">
        <img class="card-img-top" src='https://cdn.vectorstock.com/i/1000x1000/97/95/hotel-booking-round-design-template-line-icon-vector-18199795.webp'
          alt="Card image cap"/>
        <div class="card-body">
          <h2 class="card-title">ADD HOTEL HERE</h2>
          <button onClick={()=>navigate('/AddHotelInfo')} class="btn btn-outline-success">@click_here</button>
        </div>
      </div>
    </div>
  </div>

    </div>
    

   
      </div>
</div>



</div>

    </div>
 */}



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
          <button onClick={EditInformationFunction} class="btn btn-primary">Edit Info</button>
          <button onClick={BookingOfTable}  class="btn btn-success">Book Table</button>
          <button onClick={CancelBookingOfTable}  class="btn btn-danger">Cancel Table</button>
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

      <div>
        
       
            <div >
              <table className='table'>
               
               {bookingArray.map((vals)=>{
          return(
            <tr >
                <td>
                  {vals}
                </td>
                </tr>
                   )
                  })}
               
              </table>
            </div>
       
      </div>

<div>
        <div className='registerBackground' >
            <br />
        <h2>Add Hotel Here: <hr /> </h2>
        <div class="flex-container">
  <div>Hotel Id:{counter}
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
    
  <button onClick={ObjectAddToArray} class="btn btn-primary" type="button">Enter</button>
</div>
</div> 

        </div>
        </div>



    </div>
  )
}
