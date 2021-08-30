    export async function getStaticProps(request,response){
        const responseURL = await fetch(`http://localhost:5000/api/Get`,{method:'get'});
        const responeJson = await responseURL.json();
        response.setHeader('Cache-Control', 's-maxage=10','stale-while-revalidate');

        return {
            props:{
                value:responeJson
            }
        }
    }
    

