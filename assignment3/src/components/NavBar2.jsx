import React from 'react'
import { useNavigate } from 'react-router-dom'

const NavBar2 = () => {
  const navigate=useNavigate('/NavBar2')
  return (
    
    <div>
        
<div class="topnav">
  <span> <button onClick={()=>navigate('/')} type="button" class="btn btn-primary">Admin</button></span>
  <span> <button onClick={()=>navigate('/SignUpUser')} type="button" class="btn btn-primary">Users</button></span>

 </div>
    </div>
  )
}

export default NavBar2