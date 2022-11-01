import React from 'react'
import { Navigate, useNavigate } from 'react-router'
import { useState } from 'react'
import NavBar from './NavBar'
import NavBar2 from './NavBar2'
const RegisterNew = (props) => {
  const navigate=useNavigate('/RegisterNew')

  return (
    <div className='registerBackgroundOne' >
      <NavBar2/>
        <div className='hotelHeading'>
        <span>
          <h1> <b> <i> HOTEL.COM</i></b></h1>
        </span>
      </div>
        <br />
    <span>
        <div className='marginInputRegister'>
            user ID:
            <input  type="text" />
        </div>
        <br />
        <div className='marginInputRegister'>
            Password:
            <input type="password" />
        </div>
        <br />
        <div className='marginInputRegister'>
            Repeat Password:
            <input  type="password" />
            <br />
            <br />
            <button onClick={()=>navigate('/SignUpUser')}  type="button" class="btn btn-success">Register</button>
        </div>
        <br />
        
    </span>
    </div>
  )
}

export default RegisterNew