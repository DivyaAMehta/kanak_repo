import React from 'react'
import { useNavigate } from 'react-router'
import { Link } from 'react-router-dom'
import NavBar2 from './NavBar2'

const SignUpUser = () => {
  const navigate=useNavigate("/SignUpUser")
  return (
    <div>
        <NavBar2/>
        <div className='hotelHeadingUser'>
        <span>
          <h1> <b> <i> HOTEL.COM</i></b></h1>
        </span>
      </div>
    <div className='alignAllSignIn'>
    <div class="form-signin">
  <div>
    <img class="mb-4" src="https://cdn.vectorstock.com/i/1000x1000/68/28/double-bed-icon-digital-blue-vector-25336828.webp" alt="" width="72" height="57"/>
    <h1 class="h3 mb-3 fw-normal">Please sign in</h1>
    <div class="form-floating">
      <input type="email" class="form-control" id="floatingInput" placeholder="name@example.com"/>
      <label for="floatingInput">Email address</label>
    </div>
    <div class="form-floating">
      <input type="password" class="form-control" id="floatingPassword" placeholder="Password"/>
      <label for="floatingPassword">Password</label>
    </div>
    <div class="checkbox mb-3">
    </div>
    <button onClick={()=>navigate('/FirstPageUser')} class="w-100 btn btn-lg btn-warning" type='button' >Sign in</button>
    <div>
      <br/> <br/> 
      new user? <Link to="/RegisterNew">@Click_here</Link>
    </div>    
    <p class="mt-5 mb-3 text-muted">&copy; 2017–2022</p>
  </div>
</div>
    </div>
    </div>
  )
}
export default SignUpUser