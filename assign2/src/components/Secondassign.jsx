import React,{ useState } from 'react'

//when we do not declair setEmail and pass func seperately it will get reset when on change ends


const Secondassign = () => {


  function showIdPass(){
    let promptName = prompt(`if the password does not match,it wont show on console`, `${firstName} ${lastName}`)

    if(password==passwordAgain){
    return(
       <div>
        {console.log(`First Name: ${firstName}`)}
           {console.log(`Last Name: ${lastName}`)}
           {console.log(`email: ${email}`)}
           {console.log(`password: ${password}`)}
          
       </div>)}
     
   }

   function setEmailFunc(e){
        setEmail(e.target.value)
   }

   function setPasswordFunc(e){
    setPassword(e.target.value)
}

function setPasswordAgainFunc(e){
  setPasswordAgain(e.target.value)
}

const setFirstNameFunc=(e)=>{
  setFirstName(e.target.value)
}

const setLastNameFunc=(e)=>{
  setLastName(e.target.value)
}

    const [email,setEmail]=useState();
    const [password,setPassword]=useState();
    const [passwordAgain,setPasswordAgain]=useState();
    const [firstName,setFirstName]=useState();
    const [lastName,setLastName]=useState();
  return (
    <div>
        <div class='formSetup' >
    
        <div class="input-group">
  <span class="input-group-text">First and last name</span>
  <input onChange={setFirstNameFunc} type="text" aria-label="First name" class="form-control"/>
  <input onChange={setLastNameFunc} type="text" aria-label="Last name" class="form-control"/>
</div>

  <div class="mb-3">
    <label for="exampleInputEmail1" class="form-label">Email address</label>
    <input onChange={setEmailFunc} type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp"/>
    <div id="emailHelp" class="form-text">We'll never share your email with anyone else.</div>
  </div>
  <div class="mb-3">
    <label for="exampleInputPassword1" class="form-label">Password</label>
    <input onChange={setPasswordFunc} type="password" class="form-control" id="exampleInputPassword1"/>
  </div>
  <div class="mb-3">
    <label for="exampleInputPassword1" class="form-label">Type Password Again</label>
    <input onChange={setPasswordAgainFunc} type="password" class="form-control" id="exampleInputPassword1"/>
  </div>
  <div class="mb-3 form-check">
  </div>
  <button onClick={showIdPass} type="button" class="btn btn-success">Success</button>
    </div>
    </div>
  )
}

export default Secondassign