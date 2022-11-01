import React from 'react'
import { Navigate, useNavigate } from 'react-router'
import { Link } from 'react-router-dom'
import { useState } from 'react'

const BookTable=()=>{
    const navigate= useNavigate('/FirstPageUser')
    const[firstName,setFirstName]=useState();
    const[lastName,setLastName]=useState();
    const[peoples,setPeoples]=useState();
    const[array,setArray]=useState([]);
    const[bookingId,setBookingId]=useState(1)
    const CancelBooking=()=>{
    const getId=prompt('Enter Id of Booking For Cancel.')
    array[getId-1].bId=-1;
    }

    const OnClickFunction=()=>{
    const object={bId:bookingId,FName:firstName,LName:lastName,people:peoples}
      setArray([...array,object])
      setBookingId(bookingId+1)
    }
return(
        <div className='registerBackground '>             
      <div className='hotelHeadingUser'>
        <span>
          <h1> <b> <i> HOTEL.COM</i></b></h1>
        </span>
      </div>  
      <div className='marginTableBooking'> 
      <div className='buttonAvailableHotels'>
      <button  class="btn btn-outline-warning" type=""> <Link to="/FirstPageUser"> Available Hotels</Link></button>
      </div>      
      <div class="input-group">
  <span class="input-group-text">First and last name</span>
  <input onChange={(e)=>setFirstName(e.target.value)} type="text" aria-label="First name" class="form-control"/>
  <input onChange={(e)=>setLastName(e.target.value)} type="text" aria-label="Last name" class="form-control"/>
</div>
</div>
<div className='marginTableBooking'>
  <input onChange={(e)=>setPeoples(e.target.value)} type="text" class="form-control" />
  <label for="floatingInput">No Of People</label>
</div>
        <div ><button onClick={OnClickFunction} type="button" class="btn btn-outline-success">BOOK!!!</button></div>   
       <br/>
       <table class="table table-striped">       
       </table>
       <div>      
       <div class="w3-container">
  <h2>Your Booking Here</h2>
  <ul class="w3-ul w3-card-4">
  {array.filter(value=>value.bId>0).map((vals)=>{
  return(
    <div>
      <h3><li class="w3-display-container">{`${vals.FName} ${vals.LName} has booked table for ${vals.people} persons (Booking Id=${vals.bId})`} <div>
      <button onClick={CancelBooking} className='btn btn-danger' type="">Cancel booking</button>
      </div></li></h3>
    </div>           
       )
      })}
    </ul>
  </div>
  <div class="w3-container">
  <h2>Booking History:</h2>
  <ul class="w3-ul w3-card-4">
  {array.map((vals)=>{
  return(
    <div>
      <h3><li class="w3-display-container">{`${vals.FName} ${vals.LName} has booked table for ${vals.people} persons`} <div>
      </div></li></h3>
    </div>           
       )
      })}
    </ul>
  </div>
       </div>
    </div>
)
}

export default BookTable