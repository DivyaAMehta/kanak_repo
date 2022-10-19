import React,{ useState } from 'react'

function Table(props){
  return(
       <div >
           <table class="table table-striped">
               
               <thead>
                   <th>USER ID</th>
                   <th>ID</th>
                   <th>TITLE</th>
                   <th>BODY</th>
               </thead>
               
               <tbody>
               
                   {props.map((vals)=>{
                       return(
                       <tr>
                           <td>{vals.userId}</td>
                           <td>{vals.id}</td>
                           <td>{vals.title}</td>
                           <td>{vals.body}</td>
                       </tr>
                       )
                   })}

{props.map((vals)=>{
      return(

          <tr>
            <td>{vals.userId}</td>
            <td>{vals.id}</td>
            <td>{vals.title}</td>
            <td>{vals.body}</td>
          </tr> 
          
      )
    })}

               </tbody>
           </table>
       </div>
   )
}


const Fourthassign = (props) => {

  const[userId,setUserId]=useState()
  const[id,setId]=useState()
  const[title,setTitle]=useState()
  const[body,setBody]=useState()
  const[array,setArray]=useState([...props.post])

  
  function onClick(){
  const object={userId,id,title,body}
  setArray([...array,object])
  setUserId("")
     
    }
  return (
  <div>
  <div class="inputBody">
  <div class="input-group"> 
  <span class="input-group-text"><pre><b>USERID </b></pre></span>
  <textarea  onChange={(e)=>setUserId(e.target.value)} class="form-control" placeholder="Enter userId here" aria-label="With textarea"></textarea>
  </div>
  <br />
  <div class="input-group">
    <span  class="input-group-text"> <pre> <b>ID    </b></pre></span>
  <textarea onChange={(e)=>setId(e.target.value)} class="form-control" placeholder="Enter id here" aria-label="With textarea"></textarea>
  </div>
  <br />
  <div class="input-group">
  <span class="input-group-text"> <pre> <b>TITLE</b> </pre></span>
  <textarea onChange={(e)=>setTitle(e.target.value)} class="form-control" placeholder="Enter Title here" aria-label="With textarea"></textarea>
  </div>
  <br />
  <div class="input-group">
  <span class="input-group-text"><pre> <b>BODY </b> </pre></span>
  <textarea onChange={(e)=>setBody(e.target.value)} class="form-control" placeholder="Enter Body info here" aria-label="With textarea"></textarea>
  </div>
  <div class="successButton">
  <button onClick={onClick} type="button" class="btn btn-success">Success</button>
  </div>

  <div>
    {Table(array)}
  </div>
  </div>
  </div>
  )

}


export default Fourthassign