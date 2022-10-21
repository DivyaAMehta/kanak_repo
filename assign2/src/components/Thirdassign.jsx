import React,{ useState } from 'react'

const Thirdassign = () => {
    const [count,setCount]=useState(0);

    const incrementCounter=()=>{
        setCount(count+1)
    }

    const decrementCounter=()=>{
        setCount(count-1)
    }

  return (
    <div className='counterSpacing'>
        <button onClick={decrementCounter} type="button" class="btn btn-danger">Decrement</button>
        <span className='counterSpac'>
        <label>{count}</label>
</span>
        <button onClick={incrementCounter} type="button" class="btn btn-success">Increment</button>

    </div>
  )
}

export default Thirdassign