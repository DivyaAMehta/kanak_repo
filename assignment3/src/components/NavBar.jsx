import React from 'react'
import { useNavigate } from 'react-router-dom'

const NavBar = () => {
  const navigate=useNavigate('/NavBar')
  return (
    
    <div>
        
<div class="topnav">
  <span> <button onClick={()=>navigate('/FirstPage')} type="button" class="btn btn-primary">Available Hotels</button></span>
  <span> <button onClick={()=>navigate('/RegisterNewUser')} type="button" class="btn btn-primary">Register Users</button></span>

 </div>
    </div>
  )
}

export default NavBar