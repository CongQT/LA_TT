import { Button, Form, Input, Radio } from "antd";
import { Link } from "react-router-dom";

function DangNhapComponent(){
    return (
    <div className="dangki">
    <div className="title">
      Đăng nhập
    </div>
    <Form
    layout="vertical"
    name="form_in_modal"
    initialValues={{
      modifier: 'public',
    }}
    
  >
    <Form.Item
    name="email"
    label="Email"
    rules={[
        {
        required: true,
        message: 'Điền email',
        },
    ]}
    className="in"
    >
    <Input style={{width:'300px'}}/>
    </Form.Item>
    <Form.Item
      name="matkhau"
      label="Mật khẩu"
      rules={[
        {
          required: true,
          message: 'Điền mật khẩu',
        },
      ]}
      className="in"
    >
      <Input style={{width:'300px'}}/>
    </Form.Item>

  </Form>
  <div>
    <Link to={"/dangki"} className="dangki1">Đăng kí</Link>
    <Link to={"/quenmk"} className="quenmk">Quên mật khẩu?</Link>
  </div>
  <Button className="dangnhapbt">
    <Link to={"/"}>Đăng nhập</Link>
  </Button>
    </div>
    )
}
export default DangNhapComponent;