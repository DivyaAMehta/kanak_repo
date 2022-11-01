import React from 'react'
import { Navigate, useNavigate } from 'react-router'
import { useState } from 'react'
import NavBar from './NavBar'
const RegisterNewUser = (props) => {
  const navigate=useNavigate('/RegisterNewUser')
  const[userId,setUserId]=useState();
  const[password,setPassword]=useState();
  const[registerUser,setRegisterUser]=useState([...props.registerUsers])

const SaveUserInArray=()=>{
 const object1={id:userId,pass:password}
  setRegisterUser([...registerUser,object1])
  
}
  return (
    <div className='registerBackground' >
      <NavBar/>
        <div className='hotelHeading'>
        <span>
          <h1> <b> <i> HOTEL.COM</i></b></h1>
        </span>
      </div>
        <br />
    <span>
        <div className='marginInputRegister'>
            user ID:
            <input onChange={(e)=>setUserId(e.target.value)} type="text" />
        </div>
        <br />
        <div className='marginInputRegister'>
            Password:
            <input type="password" />
        </div>
        <br />
        <div className='marginInputRegister'>
            Repeat Password:
            <input onChange={(e)=>setPassword(e.target.value)} type="password" />
            <br />
            <br />
            <button onClick={SaveUserInArray}  type="button" class="btn btn-success">Register</button>
        </div>
        <br />        
    </span>
    <div>
   <h1>  Register Users:</h1>
   {registerUser.map((vals)=>{
      return(
        <div>
          <ul>
            <li><h4>{vals.id}</h4></li>
          </ul>        
        </div>
      )
      })}
    </div>
   </div>
  )
}

export default RegisterNewUser