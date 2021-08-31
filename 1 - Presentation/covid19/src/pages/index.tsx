import React from "react";
import Heads from './_Head'
import _Header from './_Header'
import _SobreMim from './_SobreMim'
import _Skills from './_Skills'
import _Contato from './_Contato'
import _Home from './_Home'

export default function Home() {

  return (
    <>
      <Heads/>
      <_Header/>
      <_Home/>      
      <_SobreMim/>
    </>
  )
}
