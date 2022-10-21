import React,{ useState } from 'react'

//when we do not declair setEmail and pass func seperately it will get reset when on change ends


const Firstassign = () => {

  function showIdPass(){
    return(
       <div>
           {console.log(`email: ${email}`)}
           {console.log(`password: ${password}`)}
       </div>
   )
   }

   function setEmailFunc(e){
        setEmail(e.target.value)
   }

   function setPasswordFunc(e){
    setPassword(e.target.value)
}

    const [email,setEmail]=useState();
    const [password,setPassword]=useState();
  return (
    <div>
        <div class='formSetup' >
  <div class="mb-3">
    <label for="exampleInputEmail1" class="form-label">Email address</label>
    <input onChange={setEmailFunc} type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp"/>
    <div id="emailHelp" class="form-text">We'll never share your email with anyone else.</div>
  </div>
  <div class="mb-3">
    <label for="exampleInputPassword1" class="form-label">Password</label>
    <input onChange={setPasswordFunc} type="password" class="form-control" id="exampleInputPassword1"/>
  </div>
  <div class="mb-3 form-check">
  </div>
  <button onClick={showIdPass} type="button" class="btn btn-success">Success</button>
    </div>
    </div>
  )
}

export default Firstassign