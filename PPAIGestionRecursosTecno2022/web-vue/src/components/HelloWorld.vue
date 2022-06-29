<template>
  <div class="hello">
    <h1>{{ msg }}</h1>
  </div>
</template>

<script>
import axios from 'axios'

export default {
  name: "HelloWorld",
  data() {
    return {
      msg: "",
    };
  },
  mounted() {
    axios.get("api/MantenimientoRT/Saludar").then(response => {
      console.log(response)
      this.msg = response.data;
    });
  },
};
</script>
